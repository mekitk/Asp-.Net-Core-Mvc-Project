using Dal.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace UI.Controllers
{
    public class AdminController : Controller
    {

        Context context = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var information = context.Admins.FirstOrDefault(x=>x.User_Name==p.User_Name && x.User_Password==p.User_Password);
            if (information!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.User_Name),
                };
                var useridentity= new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                
             
                return RedirectToAction("Index","Product");

            }
            return View();
        }
    }
}
