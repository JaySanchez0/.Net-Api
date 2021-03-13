using PeopleManager.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.model
{
    public class People
    {
        public string name;

        private int age;

        private int documentNumber;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            if (value < 0) throw new PeopleException("Invalid Age");
            age = value;
        }


        public int GetDocumentNumber()
        {
            return documentNumber;
        }

        public void SetDocumentNumber(int value)
        {
            documentNumber = value;
        }

        public string GetName() {
            return name;
        }

        public void SetName(string value) {
            name = value;
        }
    }
}
