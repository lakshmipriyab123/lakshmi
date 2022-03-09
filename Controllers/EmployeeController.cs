using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//controller
namespace CRUDUsingMVCwithAdoDotNet.Tests.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
		//return view for index
            return View();
        }
    }

}