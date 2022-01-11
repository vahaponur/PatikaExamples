using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public class PhoneNumber:IEntity
    {
        static int _nextId;
        public int Id { get; set; }
        public string Number { get; set; }
        public int PersonId { get; set; }
        public PhoneNumber()
        {
            Id = ++_nextId;
        }

    }
}
