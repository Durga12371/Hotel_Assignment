using Microsoft.AspNetCore.Mvc;
using Hotel_Assignment.Models;

namespace Hotel_Assignment.Controllers
{
    public class HotelBookingController : Controller
    { 
         private static List<HotelBooking> _booking=new List<HotelBooking>();
        public IActionResult HotelBookingDetails(HotelBooking booking)
        {
            _booking.Add(booking);
            return Redirect(nameof(Index));
            
        }
        public IActionResult Index() {
           
            return View(_booking);
        }
        public IActionResult Create()
        {
            var de = new HotelBooking();
            return View(de);
        }
    }
}
