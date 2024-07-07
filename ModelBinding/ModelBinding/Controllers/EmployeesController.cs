using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmpNo=10,EmpName="Ashwin",Basic=99999,DeptNo=10});
            empList.Add(new Employee { EmpNo=11,EmpName="Bhavesh",Basic=91999,DeptNo=11});
            empList.Add(new Employee { EmpNo=12,EmpName="Ayesha",Basic=99164,DeptNo=12});
            empList.Add(new Employee { EmpNo=13,EmpName="Ashish",Basic=95555,DeptNo=11});
            empList.Add(new Employee { EmpNo=14,EmpName="Chinmay",Basic=77999,DeptNo=10});
            return View(empList);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id = 1)
        {
            Employee empObj = new Employee();
            empObj.EmpNo = id;
            empObj.EmpName = "Ashwin";
            empObj.Basic = 999999;
            empObj.DeptNo = 11;

            return View(empObj);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //public ActionResult Create(int EmpNo, string Name, decimal Basic, int DeptNo)//Binding
        //public ActionResult Create(Employee empObj, IFormCollection collection,int EmpNo, string Name, decimal Basic, int DeptNo)//Model
        public ActionResult Create(Employee empObj)
        {
            try
            {
               /* string name = collection["Name"];  // instead if this pass obj in parameter
                string empno = collection["EmpNo"];
                string basic = collection["Basic"];
                string empNo = collection["DeptNo"];*/
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index"); 
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id )
        {
            Employee empObj = new Employee();
            empObj.EmpNo = id;
            empObj.EmpName = "Ashwin";
            empObj.Basic = 999999;
            empObj.DeptNo = 11;
            return View(empObj);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee empObj)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id = 1)
        {
            Employee empObj = new Employee();
            empObj.EmpNo = id;
            empObj.EmpName = "Ashwin";
            empObj.Basic = 999999;
            empObj.DeptNo = 11;
            return View(empObj);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee empObj)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
