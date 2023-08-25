using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using PartyInvites.Data;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext Db)
        {
            _context = Db;


        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InvitationForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult InvitationForm(GuestRespond guestRespond)
        {


            if (ModelState.IsValid)
            {
                _context.Add(guestRespond);
                _context.SaveChanges();
            }

            return View("Thanks", guestRespond);
        }


        [HttpGet]

        public IActionResult Guests()
        {
            List<GuestRespond> guests = _context.guestsInvitation.ToList();

            return View(guests);
        }

        public IActionResult ListResponse()
        {
            List<GuestRespond> guestToAttend = _context.guestsInvitation.Where(x => x.willAttend == true).ToList();
            return View(guestToAttend);
        }

    }
}