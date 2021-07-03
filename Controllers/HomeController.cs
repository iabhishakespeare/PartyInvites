using PartyInvites.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()      //default view or we can say homepage accessible at localhost:5000/home
        {
            return View();
        }
        [HttpGet]
        public ViewResult Rsvpform(){
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // TODO: store response from guest
        if (ModelState.IsValid) {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            } else {
                return View();
        }
}
        public ViewResult ListResponses() {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
}
    }
}
