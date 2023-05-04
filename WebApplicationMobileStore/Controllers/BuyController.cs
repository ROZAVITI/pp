using Microsoft.AspNetCore.Mvc;
using WebApplication2rrr.Models;

namespace WebApplicationMobileStore.Controllers
{
    public class BuyController : Controller
    {
        MobileContext db;
        public static int globalId;
        public BuyController(MobileContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Buy(int id)
        {
            globalId = id;
            Phone phone = db.Phones.Find(id);
            return View("~/Views/Buy.cshtml", phone);
        }


        [HttpPost]
        public IActionResult Buy1(string address)
        {
            //Phone phone = db.Phones.Find(id);
            User user = db.Users.Find(1);
            db.Orders.Add(
                new Order
                {
                    UserId = 1,
                    ContactTelephone = user.NumberTelephone,
                    Address = address,
                    PhoneId = globalId
                }
            ); 
            db.SaveChanges();
            return View("~/Views/BuyT.cshtml", user);
        }
    }
}
