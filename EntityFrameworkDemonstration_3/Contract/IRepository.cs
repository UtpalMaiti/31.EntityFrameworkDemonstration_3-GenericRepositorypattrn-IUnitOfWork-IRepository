using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstration_3.Contract
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int Id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}