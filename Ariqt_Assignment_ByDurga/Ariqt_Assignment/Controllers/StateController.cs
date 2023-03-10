using BusinesLogicLayer.DataRepository;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ariqt_Assignment_One_To_many_.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class StateController : ControllerBase
    {
        private readonly IDataRepository1<State>? repository1;
        // private readonly IdataRepository1<State>? _repository2;
        public StateController(IDataRepository1<State>? _repository)
        {
            repository1 = _repository;
            // _repository2 = repository2;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return repository1.GetAll();
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = repository1.Get(id);
            return Ok(result);
        }

        // POST api/<StateController>
        [HttpPost]
        public IActionResult Post([FromBody] State obj)
        {
            if (obj == null)
            {
                return BadRequest("state is Null");
            }
            repository1.Add(obj);
            return Ok(obj);
        }

        // PUT api/<StateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State obj)
        {
            var record = repository1.Get(id);
            repository1.Update(record, obj);
        }

        // DELETE api/<StateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = repository1.Get(id);
            repository1.Delete(record);
        }
    }
}
