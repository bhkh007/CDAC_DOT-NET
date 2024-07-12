/*using Microsoft.AspNetCore.Mvc;
using Motion_Mint.Models;


namespace Motion_Mint.Controllers
{
    public class RentalController : Controller
    {
        MotionMintContext db = new MotionMintContext();
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult GetCar()
        {
            var car = db.Carregs.ToList();
           // return Json(car);
            return Json(car, JsonResultBehaviour.AllowGet );
        }


    }
}
*/

using Microsoft.AspNetCore.Mvc;
using Motion_Mint.Models;
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
        //public ActionResult GetCar()
        /*{
            var car = db.Carregs.ToList();
        return Json(car, JsonRequestBehaviour.AllowGet);
        }*/
        public IActionResult GetCar()
        {
            var cars = db.Carregs.ToList();
            return Json(cars);
        }


    }
}


