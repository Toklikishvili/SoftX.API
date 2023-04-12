using Microsoft.AspNetCore.Mvc;
using SoftX.WEB.Exceptions;
using SoftX.WEB.Models;

namespace SoftX.WEB.Controllers;

public class SignUpController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> SignUp(SignUpViewModel model)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://localhost:7050/api/v1/user/register";

            var response = await client.PostAsJsonAsync(apiUrl, model);

            var apiResponse = await response.Content.ReadAsStringAsync();

            return Json(apiResponse);
        }
    }
}
