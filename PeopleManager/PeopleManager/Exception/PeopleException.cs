using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManager.exception
{
    [Serializable]
    public class PeopleException : Exception
    {
        public PeopleException() : base() { }

        public PeopleException(string message) : base(message) { }

        public PeopleException(string message, Exception inner) : base(message, inner) { }

        protected PeopleException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
