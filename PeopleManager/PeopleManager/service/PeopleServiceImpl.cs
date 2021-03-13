using PeopleManager.model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.service
{
    public class PeopleServiceImpl : PeopleService
    {
        private ConcurrentBag<model.People> peoples;

        public PeopleServiceImpl() {
            peoples = new ConcurrentBag<model.People>();
        }

        public async Task<List<model.People>> GetPeoples() => peoples.ToList();

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
