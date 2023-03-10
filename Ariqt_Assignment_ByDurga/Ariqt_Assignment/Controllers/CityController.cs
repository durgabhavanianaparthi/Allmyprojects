using BusinesLogicLayer.DataRepository;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ariqt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CityController : ControllerBase
    {
        private readonly IDataRepository1<City>? repository1;
        private readonly IDataRepository2<City>? repository2;
        ////private readonly IdataRepository1<City>? repository1;

        public CityController(IDataRepository1<City>? _repository1, IDataRepository2<City>? _repository2)
        {
            repository1 = _repository1;
            repository2 = _repository2;
        }
        // GET: api/<CityController>
        [HttpGet]
        [Authorize]
        public IEnumerable<City> Get()
        {
            return repository1.GetAll();
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {

            var record = repository1.Get(id);
            //return record;
            if (record == null)
            {
                return NotFound("id is notvxhgfv");
            }
            else
            {
                return Ok(record);
            }

        }

        // POST api/<CityController>
        [HttpPost]
        [Authorize]
        public void Post([FromBody] City city)
        {
            repository1.Add(city);

        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        [Authorize]
        public void Put(int id, [FromBody] City city)
        {
            var record = repository1.Get(id);
            repository1.Update(record, city);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(int id)
        {
            var record = repository1.Get(id);
            repository1.Delete(record);
        }

        // GET: api/<CityController>
        [HttpGet("Include All")]
        public async Task<IActionResult> GetAllIncludeAsync()
        {
            IEnumerable<City> CityTable = await repository2.GetAllAsync();
            if (CityTable != null)
            {
                return Ok(CityTable);
            }
            else
            {
                return BadRequest("Data not found");
            }
        }
    }
}


//Return 201 return new ObjectResult(entity) { StatusCode = StatusCodes.Status201Created }; }












