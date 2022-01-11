using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public class PhoneNumberMemoryRepository:MemoryRepository<PhoneNumber>,IPhoneNumberRepository
    {
    }
}
