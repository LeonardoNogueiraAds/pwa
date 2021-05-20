using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
namespace BuffetWeb.Controllers.Admin
{
    [Authorize]
    public class AdminController : Controller
    {
        public AdminController()
        {
            
        }

        
        public IActionResult Supervisao()
        {
            return View();
        }
    }
}