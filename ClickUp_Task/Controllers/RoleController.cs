using AutoMapper;
using ClickUp_Task.DAL;
using ClickUp_Task.DTOs.RoleDTOs;
using ClickUp_Task.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClickUp_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;
        public RoleController(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Role> entities = _context.Roles.Include(r=>r.Users).Where(r=>r.IsDeleted==true).ToList();
            List<RoleToListDto> dtos = _mapper.Map<List<RoleToListDto>>(entities);
            return Ok(dtos);
        }

        [HttpGet("isdeleted")]
        public IActionResult GetDeleted()
        {
            List<Role> entities = _context.Roles.IgnoreQueryFilters().Where(r=>r.IsDeleted==true).ToList();
            List<RoleToIsDeletedDto> dtos = _mapper.Map<List<RoleToIsDeletedDto>>(entities);
            return Ok(dtos);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (!_context.Roles.Any(r=>r.RoleId==id))
            {
                return BadRequest("bad");
            }
            Role entity = _context.Roles.Include(r=>r.Users).Single(r=>r.RoleId==id);
            RoleByIdDto dto = _mapper.Map<RoleByIdDto>(entity);
            return Ok(dto);
        }

        // POST api/<RoleController>
        [HttpPost]
        public IActionResult Post([FromBody] RoleToAddDto dto)
        {
            Role entity = _mapper.Map<Role>(dto);
            _context.Roles.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RoleToUpdateDto dto)
        {
            if (!_context.Roles.Any(r=>r.RoleId==id))
            {
                return BadRequest("bad");
            }
            Role entity = _mapper.Map<Role>(dto);
            entity.RoleId = id;
            _context.Roles.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_context.Roles.Any(r=>r.RoleId==id))
            {
                return BadRequest("bad");
            }
            Role entity = _context.Roles.Find(id);
            entity.IsDeleted = true;
            _context.Roles.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
    }
}
