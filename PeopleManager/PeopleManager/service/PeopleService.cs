using PeopleManager.Exception;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.service
{
    public class PeopleService
    {
        private ConcurrentBag<model.People> peoples;

        public PeopleService() {
            peoples = new ConcurrentBag<model.People>();
        }

        public ConcurrentBag<model.People> GetPeoples() => peoples;

        public model.People GetPeople(int documentNumber) {
            return peoples.ToList().Find(p => p.GetDocumentNumber() == documentNumber);
        }

        public void AddPeople(model.People people){
            if (GetPeople(people.GetDocumentNumber()) != null) 
                   throw new PeopleException("Exist a user with same Identification");
            peoples.Add(people);
        }

        public void DeletePeople(model.People people) { 
            if(GetPeople(people.GetDocumentNumber())==null)
                throw new PeopleException("Unexist user");
        }

    }
}
