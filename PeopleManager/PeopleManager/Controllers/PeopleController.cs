using Microsoft.AspNetCore.Mvc;
using PeopleManager.service;
using System.Threading.Tasks;

namespace PeopleManager.Controllers
{
    [Route("/peoples")]
    [ApiController]
    public class PeopleController : Controller
    {
        private PeopleService peopleService;

        public PeopleController(PeopleService service):base() {
            peopleService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPeoples() {
            return Ok(await peopleService.GetPeoples());
        }

        [HttpPost]
        public async Task<IActionResult> AddPeople(model.People people)
        {
            bool add = await peopleService.AddPeople(people);
            if (add) return Accepted();
            else return BadRequest("");
        }
 
        [HttpDelete]
        public async Task<IActionResult> RemovePeople(model.People people) {
            bool isRemove = await peopleService .RemovePeople(people);
            if (isRemove) return Accepted();
            else return BadRequest();
        }
    }
}
