using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleManager.service
{
    public interface PeopleService
    {
        Task<List<model.People>> GetPeoples();

        Task<model.People> GetPeople(int documentNumber);

        Task<bool> AddPeople(model.People people);

        Task<bool> RemovePeople(model.People people);
    }
}
