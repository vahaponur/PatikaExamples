using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public class Person:IEntity
    {
        static int _nextId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Person()
        {
            Id = ++_nextId;
        }
        
    }
}
