using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){userId=1,Username="sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"},
            new User(){userId=2,Username="amit",UserPwd="amit@123",UserEmail="amit@hotmail.com"},
            new User(){userId=3,Username="kumar",UserPwd="kumar@1256",UserEmail="kumar@mail.com"},
            new User(){userId=4,Username="anisha",UserPwd="a@rohan",UserEmail="a@yahoomail.com"},
            new User(){userId=5,Username="vidisha",UserPwd="v@isha",UserEmail="v5@gmail.com"}


        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User Model)
        {
            if (ModelState.IsValid)
            {
                users.Add(Model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(Model);
            }
        }
        

    }
}
