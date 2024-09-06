using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Timetable.Models;

namespace Timetable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<CalendarEvent> events = new List<CalendarEvent>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Landing() 
        { 
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }


        [HttpGet]
        public IActionResult GetEvents() 
        {
            return Json(events);
        }

        [HttpPost]
        public IActionResult AddEvent([FromBody] CalendarEvent calendarEvent)
        {
            if (calendarEvent != null)
            {
                calendarEvent.Id = Guid.NewGuid().ToString(); // Generate a unique ID for the event
                events.Add(calendarEvent);
                return Json(new { success = true, message = "Event added successfully." });
            }

            return Json(new { success = false, message = "Invalid event data." });
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}