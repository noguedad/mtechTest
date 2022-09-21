using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using mtechTest;

namespace mtechTest.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        public ActionResult Index(string searchName)
        {
            var employees = from employee in db.Employees
                            select employee;

            if (!string.IsNullOrEmpty(searchName))
            {
                employees = employees.Where(emp => emp.Name.Contains(searchName));
            }

            return View(employees);
        }

        public ActionResult SortByDOB(string searchName)
        {
            var employees = from employee in db.Employees
                            select employee;

            if (!string.IsNullOrEmpty(searchName))
            {
                employees = employees.Where(emp => emp.Name.Contains(searchName));
            }

            employees = employees.OrderBy(emp => emp.BornDate);

            return View(employees);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LastName,RFC,BornDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.RFC = employee.RFC.ToUpper();

                if (employee.RFC == "XAXX010101000" || db.Employees.Count(emp => emp.RFC == employee.RFC) == 0)
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("RFCError", "Error");
                }
            }
            return View(employee);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return RedirectToAction("NotFound", "Error");
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LastName,RFC,BornDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.RFC = employee.RFC.ToUpper();

                if (employee.RFC == "XAXX010101000" || db.Employees.Count(emp => emp.RFC == employee.RFC && emp.Id != employee.Id) == 0)
                {
                    
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("RFCError","Error");
                }
            }
            return View(employee);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return RedirectToAction("NotFound", "Error");
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
