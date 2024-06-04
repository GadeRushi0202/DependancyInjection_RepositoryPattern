using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Services;

namespace RepositoryPatternDemo.Controllers
{
    public class EmployeeeController : Controller
    {
        private readonly IEmployeeService service;
        public EmployeeeController(IEmployeeService service)
        {
            this.service = service;
        }
        // GET: EmployeeeController
        public ActionResult Index()
        {
            return View(service.GetEmployeees());
        }

        // GET: EmployeeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = service.GetEmployeeeById(id);
            return View(model);
        }

        // GET: EmployeeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employeee employeee)
        {
            try
            {
                int result = service.AddEmployeee(employeee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();  // remain on Create page.
            }
        }

        // GET: EmployeeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employeee employeee)
        {
            try
            {
                int result = service.UpdateEmployeee(employeee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteEmployeee(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
