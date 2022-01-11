using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;

namespace TelefonRehberi.Concreate
{
    public class MemoryRepository<T> : IRepositoryBase<T> where T : class, IEntity, new()
    {
        public List<T> _entityList { get; set; }

        public MemoryRepository()
        {
            _entityList = new List<T>();
        }


        public void Add(T entity)
        {
            _entityList.Add(entity);
        }

        public void Delete(T entity)
        {
           var deleted= _entityList.Remove(entity);
            if (deleted)
            {
                Console.WriteLine("Successfully Deleted");
            }
        }

        public List<T> GetAll()
        {
            return _entityList;
        }

        public T GetById(int id)
        {
            return _entityList.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            int entityToUpdate = _entityList.FindIndex(e => e.Id==entity.Id);
            if (entityToUpdate !=-1)
            {
                _entityList[entityToUpdate] = entity;
                return;
            }
            Console.WriteLine("Entity cannot be found");

        }
    }
}
