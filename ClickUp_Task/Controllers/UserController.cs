using AutoMapper;
using ClickUp_Task.DAL;
using ClickUp_Task.DTOs.UserDTOs;
using ClickUp_Task.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClickUp_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;
        public UserController(MyContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            List<User> entities = _context.Users.Include(u=>u.Tasks).ToList();
            List<UserToLIstDto> dtos = _mapper.Map<List<UserToLIstDto>>(entities); 
            return Ok(dtos);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (!_context.Users.Any(u=>u.UserId==id))
            {
                return BadRequest("bad");
            }
            User entity = _context.Users.Include(u=>u.Tasks).Include(u=>u.Role).Single(u=>u.UserId==id);
            UserByIdDto dto = _mapper.Map<UserByIdDto>(entity);
            return Ok(dto);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserToAddDto dto)
        {
            User entity = _mapper.Map<User>(dto);
            _context.Users.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserToUpdateDto dto)
        {
            if (!_context.Users.Any(u=>u.UserId==id))
            {
                return BadRequest("bad");
            }
            User entity = _mapper.Map<User>(dto);
            entity.RoleId = id;
            _context.Users.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_context.Users.Any(u=>u.UserId==id))
            {
                return BadRequest("bad");
            }
            User entity = _context.Users.Find(id);
            entity.IsDeleted = true;
            _context.Users.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
    }
}
