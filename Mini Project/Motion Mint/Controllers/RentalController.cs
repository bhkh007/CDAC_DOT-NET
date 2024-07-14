using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motion_Mint.Models;
using System;
using System.Linq;
namespace Motion_Mint.Controllers
{
    public class RentalController : Controller
    {
        MotionMintContext db = new MotionMintContext();

        public ActionResult Index()
        {
           return View();
        }

        [HttpGet]
        public IActionResult GetCar()
        {
            var cars = db.Carregs.ToList();
            return Json(cars);
        }


        [HttpPost]
        public IActionResult Getid(int? id)
        {
            var customer = db.Customers
                             .Where(s => s.Id == id)
                             .Select(s => s.Custname)
                             .FirstOrDefault();
            return Json(customer);
        }


        [HttpPost]
        public IActionResult Getavil(string carno)
        {
            var car = db.Carregs
                        .Where(c => c.Carno == carno)
                        .Select(c => c.Available)
                        .FirstOrDefault();

            return Json(car);
        }


        [HttpPost]
        public async Task<IActionResult> Save(Rental rent)
        {
            Console.WriteLine(rent.Carid + " " + rent.Custid + " " + rent.Id);
            try
            {
                {
                    {
                        db.Rentals.Add(rent);
                        await db.SaveChangesAsync();
                        return View("details", rent);

                        //db.Rentals.Add(rent);
                        //db.SaveChanges(); 


                        //var car = db.Carregs.SingleOrDefault(e => e.Carno == rent.Carid);
                        //if (car == null)
                        //{
                        //    return NotFound("Car number is not valid");
                        //}
                        //car.Available = "No";
                        //db.Entry(car).State = EntityState.Modified; 
                        //db.SaveChanges(); 

                        return RedirectToAction("Index");
                    }


                    return View(rent);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Exception occurred: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.StackTrace}");
                    if (ex.InnerException.InnerException != null)
                    {
                        Console.WriteLine($"Inner inner exception: {ex.InnerException.StackTrace}");
                    }
                }
                return StatusCode(500, $"An error occurred while processing your request: {ex.Message}");
            }
        }


    }
}

