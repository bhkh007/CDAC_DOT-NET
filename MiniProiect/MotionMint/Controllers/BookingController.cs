using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotionMint.Models;
using MotionMint.ViewModels;

namespace MotionMint.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index() => View(await _context.Bookings.Include(b => b.Car).Include(b => b.User).ToListAsync());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var booking = new Booking
                {
                    CarId = model.CarId,
                    UserId = model.UserId,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    TotalPrice = model.TotalPrice
                };

                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            var model = new BookingViewModel
            {
                CarId = booking.CarId,
                UserId = booking.UserId,
                StartDate = booking.StartDate,
                EndDate = booking.EndDate,
                TotalPrice = booking.TotalPrice
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var booking = await _context.Bookings.FindAsync(id);
                if (booking == null)
                {
                    return NotFound();
                }

                booking.CarId = model.CarId;
                booking.UserId = model.UserId;
                booking.StartDate = model.StartDate;
                booking.EndDate = model.EndDate;
                booking.TotalPrice = model.TotalPrice;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
