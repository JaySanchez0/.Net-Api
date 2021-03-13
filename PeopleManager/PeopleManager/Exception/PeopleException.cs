using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.Exception
{
    public class PeopleException : System.Exception
    {
        public PeopleException(string msg):base(msg) {
            
        }
    }
}
