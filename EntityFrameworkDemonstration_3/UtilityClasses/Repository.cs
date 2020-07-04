using EntityFrameworkDemonstration_3.Contract;
using EntityFrameworkDemonstration_3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_3.UtilityClasses
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext dbContext;
        private DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            dbContext = context;

            dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int Id)
        {
            //it will seach if Primary keyise already set      (find method)
            return dbSet.Find(Id);
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}