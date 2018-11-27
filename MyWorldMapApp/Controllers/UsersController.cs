using Microsoft.AspNetCore.Mvc;
using MyWorldMapApp.Dto;
using MyWorldMapApp.Repositories;
using System.Collections.Generic;

namespace MyWorldMapApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITravelDestinationRepository _travelDestinationRepository;

        public UsersController(IUserRepository userRepository, 
                               ITravelDestinationRepository travelDestinationRepository)
        {
            _userRepository = userRepository;
            _travelDestinationRepository = travelDestinationRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get()
        {
            var users = _userRepository.GetAll();
            if (users != null)
            {
                return Ok(users);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var user = _userRepository.Get(id);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] UserDTO user)
        {
            if (ModelState.IsValid)
            {
                var userToBeSaved = _userRepository.Add(user);
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Edit([FromBody]UserDTO user)
        {
            if (ModelState.IsValid)
            {
                var userToBeEdited = _userRepository.Get(user.Id);
                if (userToBeEdited != null)
                {
                    return Ok(userToBeEdited);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            if (ModelState.IsValid)
            {
                var user = _userRepository.Get(id);
                if (user != null)
                {
                    _userRepository.Delete(user);
                    return Ok(user);
                } else
                {
                    return BadRequest();
                }
                
            }
            else
            {
                return BadRequest();
            }
        }
    }
}