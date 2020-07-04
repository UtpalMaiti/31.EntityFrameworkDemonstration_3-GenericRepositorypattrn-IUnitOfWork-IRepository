using EntityFrameworkDemonstration_3.Contract;
using EntityFrameworkDemonstration_3.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkDemonstration_3.Controllers
{
    public class DepartmentController : Controller
    {
        private IUnitOfWork unit;

        public DepartmentController()
        {
            unit = new UnitOfWork();
        }

        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
    }
}