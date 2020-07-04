using EntityFrameworkDemonstration_3.Contract;
using EntityFrameworkDemonstration_3.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkDemonstration_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private IUnitOfWork unit;

        public HomeController()
        {
            unit = new UnitOfWork();
        }

        public ActionResult Index()
        {
            //unit.DepartmentRepository.GetAll();
            return View(unit.EmployeeRepository.GetAll());
        }

        public ActionResult DeleteEmployee(int Id)
        {
            var employee = unit.EmployeeRepository.GetById(Id);

            unit.EmployeeRepository.Delete(employee);

            unit.Save();

            return RedirectToAction("Index");
        }
    }
}