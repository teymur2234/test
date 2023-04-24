using AutoMapper;
using ClickUp_Task.DAL;
using ClickUp_Task.DTOs.TaskDTOs;
using ClickUp_Task.Entity;
using Microsoft.AspNetCore.Mvc;


namespace ClickUp_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;
        public TaskController(MyContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/<TaskController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Entity.Task> entity = _context.Tasks.ToList();
            List<TaskToListDto> dtos = _mapper.Map<List<TaskToListDto>>(entity);
            return Ok(dtos);
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            if (!_context.Tasks.Any(t=>t.TaskId==id))
            {
                return BadRequest("bad");
            }
            Entity.Task entity = _context.Tasks.Find(id);
            TaskByIdDto dto = _mapper.Map<TaskByIdDto>(entity);
            return Ok(dto) ;
        }

        // POST api/<TaskController>
        [HttpPost]
        public IActionResult Post([FromBody] TaskToAddDto dto)
        {
            Entity.Task entity = _mapper.Map<Entity.Task>(dto);
            _context.Tasks.Add(entity);
            _context.SaveChanges();
            return Ok(dto);
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] TaskToUpdateDto dto)
        {
            Entity.Task entity = _mapper.Map<Entity.Task>(dto);
            entity.TaskId = id;
            //_context.Entry(entity).Property(m => m.TaskStatusId).CurrentValue;
            _context.Tasks.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpPut("{id}/status")]
        public IActionResult changestatus([FromRoute]int id, [FromBody] TaskToChangeStatusDto dto)
        {
            if (!_context.Tasks.Any(t=>t.TaskId==id))
            {
                return BadRequest("bad");
            }
            Entity.Task entity = _mapper.Map<Entity.Task>(dto);
            entity.TaskId = id;
            _context.Tasks.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_context.Tasks.Any(t=>t.TaskId==id))
            {
                return BadRequest("bad");
            }
            Entity.Task entity = _context.Tasks.Find(id);
            entity.IsDeleted=true;
            _context.Tasks.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
    }
}
