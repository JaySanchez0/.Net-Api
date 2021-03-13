using PeopleManager.exception;
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

        private static PeopleService instance;

        public static PeopleService getInstance() {
            if (instance == null){
                instance = new PeopleService();
                instance.AddPeople(new model.People("Juan", 3, 1));
            }
            return instance;
        }
        private PeopleService() {
            peoples = new ConcurrentBag<model.People>();
        }

        public ConcurrentBag<model.People> GetPeoples() => peoples;

        public model.People GetPeople(int documentNumber) {
            foreach (model.People people in this.peoples) {
                if (people.DocumentNumber == documentNumber) return people;
            }
            return null;
        }

        public void AddPeople(model.People people){
            Console.WriteLine("Entro add");
                //if (GetPeople(people.DocumentNumber) != null)
                //    throw new PeopleException("Exist a user with same Identification");
                peoples.Add(people);
        }

        public void DeletePeople(model.People people) { 
            if(GetPeople(people.DocumentNumber)==null)
                throw new PeopleException("Unexist user");
        }

    }
}
