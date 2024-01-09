using MVCEntityFrameworkCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEntityFrameworkCRUD.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public ActionResult Index(EmployeeViewModel employeeViewModel = null)
        {
            if (employeeViewModel == null)
            {
                employeeViewModel = new EmployeeViewModel();
            }
            if (employeeViewModel.EmployeeSearchDTO == null)
            {
                employeeViewModel.EmployeeSearchDTO = new EmployeeDTO();
            }
            return View(employeeViewModel);
        }

        [HttpPost]
        public ActionResult Search( FormCollection formCollection)
        {
            string action = formCollection["action"];
            string lastName = formCollection["lastName"];
            string firstName = formCollection["firstName"];

            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                EmployeeSearchDTO = new EmployeeDTO()
            };

            if (action != "Search")
            {
                lastName = string.Empty;
                firstName = string.Empty;
            }

            employeeViewModel.EmployeeSearchDTO.last_name = lastName;
            employeeViewModel.EmployeeSearchDTO.first_name = firstName;
            employeeViewModel.EmployeeDTO = GetEmployeeData(lastName, firstName);

            return View("Index", employeeViewModel);
        }

        private static List<EmployeeDTO> GetEmployeeData(string lastName, string firstName)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            using (var db = new employeeEntities())
            {

                var query = from employee in db.employees
                            join job in db.jobs on employee.job_id equals job.job_id
                            where ((employee.last_name ?? "").Contains(lastName) &&
                            (employee.first_name ?? "").Contains(firstName))
                            select new EmployeeDTO()
                            {
                                first_name = employee.first_name,
                                last_name = employee.last_name,
                                job_title = job.job_title,
                                hire_date = employee.hire_date
                            };
                employees = query.ToList();
            }

            return employees;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}