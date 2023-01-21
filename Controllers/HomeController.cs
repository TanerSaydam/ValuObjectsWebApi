using Microsoft.AspNetCore.Mvc;
using ValuObjectsWebApi.Models;
using ValuObjectsWebApi.ValueObjects;

namespace ValuObjectsWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    //Value Objects ile Primitive Obsession sorununu çözme
    [HttpGet]
    public IActionResult CreateUser()
    {
        User user = new(
            FirstName.Create("FirstName"),
            "LastName",
            "Email");

        //Kayıt işlemi

        return Ok();
    }
}
