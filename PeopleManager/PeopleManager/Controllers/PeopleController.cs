using Microsoft.AspNetCore.Mvc;
using PeopleManager.service;
using System;
using System.Collections.Concurrent;

namespace PeopleManager.Controllers
{
    [Route("/peoples")]
    [ApiController]
    public class PeopleController : Controller
    {
        private PeopleService peopleService = PeopleService.getInstance();

        [HttpGet]
        public IActionResult GetAllPeoples() {
            return Ok(peopleService.GetPeoples());
        }

        [HttpPost]
        public IActionResult AddPeople(model.People people)
        {
            bool add = peopleService.AddPeople(people);
            if (add) return Accepted();
            else return BadRequest("");
        }

        [HttpDelete]
        public IActionResult RemovePeople(model.People people) {
            bool isRemove = peopleService.RemovePeople(people);
            if (isRemove) return Accepted();
            else return BadRequest();
        }
    }
}
