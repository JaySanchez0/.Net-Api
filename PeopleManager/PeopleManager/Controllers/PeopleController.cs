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

        public PeopleController():base() {
        }

        [HttpGet]
        public IActionResult GetAllPeoples() {
            return Ok(peopleService.GetPeoples());
        }

        [HttpPost]
        public IActionResult AddPeople(model.People people)
        {
            try{
                peopleService.AddPeople(people);
                return Accepted();
            }
            catch (Exception e) {
                return BadRequest();
            }
        }
    }
}
