using Microsoft.AspNetCore.Mvc;
using PeopleManager.service;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.Controllers
{
    [Route("/peoples")]
    [ApiController]
    public class PeopleController : Controller
    {
        private PeopleService peopleService = new PeopleService();

        [HttpGet]
        public ConcurrentBag<model.People> GetAllPeoples() {
            return peopleService.GetPeoples();
        }
    }
}
