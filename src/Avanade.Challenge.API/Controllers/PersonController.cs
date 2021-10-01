using Avanade.Challenge.Domain;
using Avanade.Challenge.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanade.Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IRepository<Person> _repository;

        public PersonController(IRepository<Person> repository)
        {
            _repository = repository;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return (IEnumerable<Person>)await _repository.GetAllAsync();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person person)
        {
            if (person.Validate())
            {
                int result = await _repository.AddAsync(person);
                return StatusCode(201, new { id = result });
            }

            return StatusCode(403, "Invalid");
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] Person person)
        {
            await _repository.DeleteAsync(person);

            return Ok("Delete success");
        }
    }
}
