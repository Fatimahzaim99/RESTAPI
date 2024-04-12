using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapiCDN.Models;

namespace webapiCDN.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private readonly FreelancerRepository _freelancerRepository;

        public FreelancerController(FreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Freelancer>>> GetAllFreelancers()
        {
            var freelancers = await _freelancerRepository.GetAllFreelancers();
            return Ok(freelancers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Freelancer>> GetFreelancerById(int id)
        {
            var freelancer = await _freelancerRepository.GetFreelancerById(id);
            if (freelancer == null)
            {
                return NotFound();
            }
            return freelancer;
        }

        [HttpPost]
        public async Task<ActionResult<Freelancer>> AddUser(Freelancer freelancer)
        {
            await _freelancerRepository.AddFreelancer(freelancer);
            return CreatedAtAction(nameof(GetFreelancerById), new { id = freelancer.Id }, freelancer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFreelancer(int id, Freelancer freelancer)
        {
            if (id != freelancer.Id)
            {
                return BadRequest();
            }

            await _freelancerRepository.UpdateFreelancer(freelancer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFreelancer(int id)
        {
            await _freelancerRepository.DeleteFreelancer(id);
            return NoContent();
        }
    }
}
