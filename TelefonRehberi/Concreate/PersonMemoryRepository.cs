using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public class PersonMemoryRepository:MemoryRepository<Person>,IPersonRepository
    {
    }
}
