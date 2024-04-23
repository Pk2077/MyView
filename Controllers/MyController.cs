using Microsoft.AspNetCore.Mvc;
using ResourcesLib.Models;

namespace MyView.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Validate credentials and authenticate user
            if (ModelState.IsValid)
            {
                // Perform authentication logic (e.g., validate username and password)
                if (UserIsAuthenticated(model.UserName, model.Password))
                {
                    // Redirect to Home view upon successful login
                    return RedirectToAction("Home", "My");
                }
            }

            // If authentication fails, return the login view with error
            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }
        public IActionResult Home()
        {
            return View(); // Return the home view (e.g., Home.cshtml)
        }

        private bool UserIsAuthenticated(string username, string password)
        {
            // Perform actual user authentication logic here (e.g., check against database)
            // Return true if authentication is successful, otherwise false
            // This is a placeholder method, replace with your actual authentication logic
            return (username == "demo" && password == "password");
        }
    }
}
