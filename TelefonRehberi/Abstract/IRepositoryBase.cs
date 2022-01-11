using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.Abstract
{
    public interface IRepositoryBase<T> where T:class,IEntity,new()
    {
        List<T> _entityList { get; set; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
