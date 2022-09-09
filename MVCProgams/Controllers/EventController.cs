using Microsoft.AspNetCore.Mvc;
using MVCProgams.Models;
using System.Reflection;

namespace MVCProgams.Controllers
{
    public class EventsController : Controller
    {

        public List<Booking> events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "ask CEO", EventsDate = DateTime.Today, Qty = 10 });

            return View(events);

        }
    }
}
     
    

