using EntityFrameworkDemonstration_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstration_3.Contract
{
    public interface IUnitOfWork
    {
        IRepository<EmpInfo> EmployeeRepository { get;}

        IRepository<DeptInfo> DepartmentRepository { get; }
        void Save();
    }
}
