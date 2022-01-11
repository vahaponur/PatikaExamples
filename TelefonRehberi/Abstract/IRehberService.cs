using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Concreate;

namespace TelefonRehberi.Abstract
{
    public interface IRehberService
    {
  
        void Add(RehberDto entity);
        void Update(RehberDto entity);
        void Delete(RehberDto entity);
        RehberDto GetByName(string name);
        List<RehberDto> GetAll();
        RehberDto GetByNumber(string number);
        List<RehberDto> GetAllByName(string name);
        
    }
}
