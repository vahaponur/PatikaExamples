using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    class RehberManager : IRehberService
    {
        IPhoneNumberRepository _phoneNumberRepository;
        IPersonRepository _personRepository;

        public RehberManager()
        {
            _personRepository = new PersonMemoryRepository();
            _phoneNumberRepository = new PhoneNumberMemoryRepository();
        }

        public void Add(RehberDto entity)
        {
            _personRepository.Add(entity.Person);
            _phoneNumberRepository.Add(entity.PhoneNumber);
        }

        public void Delete(RehberDto entity)
        {
            _phoneNumberRepository.Delete(entity.PhoneNumber);
            _personRepository.Delete(entity.Person);
        }

        public List<RehberDto> GetAll()
        {
            List<RehberDto> all = new List<RehberDto>();
            var persons =_personRepository.GetAll();
            var phoneNumbes =_phoneNumberRepository.GetAll();
            for (int i = 0; i < persons.Count; i++)
            {
                RehberDto rehberDto = new RehberDto
                {
                    Person = persons[i],
                    PhoneNumber = phoneNumbes[i]

                };
                all.Add(rehberDto);
            }
            return all;
        }

        public List<RehberDto> GetAllByName(string name)
        {
            return GetAll().Where(r => string.Equals(name, r.Person.FirstName, StringComparison.CurrentCultureIgnoreCase) || string.Equals(name, r.Person.LastName, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public RehberDto GetByName(string name)
        {
            return GetAll().Where(r => string.Equals(name,r.Person.FirstName,StringComparison.CurrentCultureIgnoreCase) || string.Equals(name, r.Person.LastName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        }

        public RehberDto GetByNumber(string number)
        {
            return GetAll().Where(r => r.PhoneNumber.Number == number).FirstOrDefault();
        }

        public void Update(RehberDto entity)
        {
            _personRepository.Update(entity.Person);
            _phoneNumberRepository.Update(entity.PhoneNumber);
        }
    }
}
