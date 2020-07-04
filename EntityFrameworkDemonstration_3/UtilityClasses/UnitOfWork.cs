using EntityFrameworkDemonstration_3.Contract;
using EntityFrameworkDemonstration_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_3.UtilityClasses
{
    public class UnitOfWork : IUnitOfWork
    {
        IRepository<EmpInfo> employeeRepository;

        IRepository<DeptInfo> deptRepository;

        EmployeeDBEntities dbContext;

        public UnitOfWork()
        {
            dbContext = new EmployeeDBEntities();
        }
        public IRepository<EmpInfo> EmployeeRepository
        {
            get
            {
                if (employeeRepository == null)
                {
                    employeeRepository = new Repository<EmpInfo>(dbContext);
                }

                return employeeRepository;
            }
        }

        public IRepository<DeptInfo> DepartmentRepository
        {
            get
            {
                if (deptRepository == null)
                {
                    deptRepository = new Repository<DeptInfo>(dbContext);
                }

                return deptRepository;
            }
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}