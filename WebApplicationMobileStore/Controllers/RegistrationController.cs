using Microsoft.AspNetCore.Mvc;
using WebApplication2rrr.Models;

namespace WebApplicationMobileStore.Controllers
{
    public class RegistrationController : Controller
    {
        MobileContext db;
        public RegistrationController(MobileContext context)
        {
            db = context;
        }

    }
}
