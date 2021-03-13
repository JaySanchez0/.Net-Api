using PeopleManager.exception;
using PeopleManager.model;
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

        public async Task<ConcurrentBag<model.People>> GetPeoples() => peoples;

        public async Task<model.People> GetPeople(int documentNumber) {
            foreach (model.People people in this.peoples) {
                if (people.DocumentNumber == documentNumber) return people;
            }
            return null;
        }

        public async Task<bool> AddPeople(model.People people){
            if (await GetPeople(people.DocumentNumber) != null)
                return false;
            peoples.Add(people);
            return true;
        }

        public async Task<bool> RemovePeople(People people){
            if (await GetPeople(people.DocumentNumber) == null) return false;
            return peoples.TryTake(out people);
        }

    }
}
