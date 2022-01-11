using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public  class RehberDto:IDto
    {
        
        public Person Person { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    
    }
}
