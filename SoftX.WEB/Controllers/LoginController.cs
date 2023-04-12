using Microsoft.AspNetCore.Mvc;
using SoftX.WEB.Exceptions;

namespace SoftX.WEB.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> LogIn(string txtLoginEmail, string txtLoginPassword)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://localhost:7050/api/v1/user/login";

            var response = await client.PostAsJsonAsync(apiUrl, new { Email = txtLoginEmail, Password = txtLoginPassword.HashPassword()});

            var apiResponse = await response.Content.ReadAsStringAsync();

            return Json(apiResponse);
        }
    }
}
