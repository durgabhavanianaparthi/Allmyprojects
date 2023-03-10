using Microsoft.AspNetCore.Mvc;
using One_To_Many_ForeignKey_using.Model;
using One_To_Many_ForeignKey_using.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace One_To_Many_ForeignKey_using.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IDataRepository<State>? repository;

        public StateController(IDataRepository<State>? _repository)
        {
            repository = _repository;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return repository.GetAll();
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = repository.Get(id);
            return Ok(result);
        }

        // POST api/<StateController>
        [HttpPost]
        public IActionResult Post([FromBody] State obj)
        {
            //repository.Add(state);

            if (obj == null)
            {
                return BadRequest("state is Null");
            }
            repository.Add(obj);
            return Ok(obj);
        }

        // PUT api/<StateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State state)
        {
            var record = repository.Get(id);
            repository.Update(record, state);
        }

        // DELETE api/<StateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = repository.Get(id);
            repository.Delete(record);
        }
    }
}
