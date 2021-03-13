using PeopleManager.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.model
{
    public class People
    {
        private string _name;

        public string Name { get=>_name; set { _name = value; } } 

        private int _age;
        public int Age { get => _age; set { _age = value; } }

        private int _documentNumber;

        public int DocumentNumber { get => _documentNumber; set { _documentNumber = value; } }

        public People() {

        }

        public People(string name, int age, int documentNumber) : base()
        {
            this._name = name;
            this._age = age;
            this._documentNumber = documentNumber;
        }
    }
}
