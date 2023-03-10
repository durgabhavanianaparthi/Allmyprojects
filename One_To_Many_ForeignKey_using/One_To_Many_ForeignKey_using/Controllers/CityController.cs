using Microsoft.AspNetCore.Mvc;
using One_To_Many_ForeignKey_using.Model;
using One_To_Many_ForeignKey_using.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace One_To_Many_ForeignKey_using.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    { 
         private readonly IDataRepository<City>? repository;

        public CityController(IDataRepository<City>? repository)
        {
            this.repository = repository;
        }
        // GET: api/<CityController>
        [HttpGet] 
        public IEnumerable<City> Get()
        {
            return repository.GetAll();
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public City Get(int id)
        {
            var record =repository.Get(id);
            return record;
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] City city)

        {
            repository.Add(city);

        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {
            var record = repository.Get(id);
            repository.Update(record, city);

        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = repository.Get(id);
            repository.Delete(record);
        }
    }
}
