using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Queries.Dogs;
using Application.Queries.Dogs.GetDogByIdQuery;
using Application.Queries.GetAllDogs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediator;

        public DogsController(IMediator mediator)
        {
            _mediator = mediator;
        } 

        // This is API endpoint where we get all dogs from "MockDatabse"
        // url is api/v1/Dog/getAllDogs
        // GET: api/<DogController>
        [HttpGet]
        [Route("GetAllDogs")]
        public async Task <IActionResult> GetAllDogs()
        { 
            return Ok( await _mediator.Send(new GetAllDogsQuery()));
        }

        // This is API endpoint where we get a dog by id from "MockDatabse"
        // url is api/v1/Dog/getDogById 
        // GET: api/<DogController>
        [HttpGet]
        [Route("GetDogById/{dogid}")]
        public async Task <IActionResult> GetDogById(Guid dogid)
        {
            return Ok( await _mediator.Send(new GetDogByIdQuery(dogid)));
        }

        //This is API ednpoint where we create new dog for "MockDatabase"
        // POST api/<DogController>
        [HttpPost]
        [Route("CreateNewDog")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DogController>/5
        [HttpPut]
        [Route("UpdateDogById/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DogController>/5
        [HttpDelete]
        [Route("DeleteDogsById/{id}")]
        public void Delete(int id)
        {
        }
    }
}
