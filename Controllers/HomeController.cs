using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class UserRequest //objetos daa classe representação de dados do usuário que vem na requisição
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction() 
    {
        return View();
    }

    public string QueryStringTest([FromQuery] string q, [FromQuery] string nome)
    {
        return $"Chegou aqui {q} e {nome}";
    }

    // public string FormDataTest([FromForm] string name, [FromForm] string email) 
    // {
    //     return $"Nome: {name}, E-mail: {email}";
    // }

    public IActionResult Formulary() 
    {
        return View();
    }

    public string FormDataTest([FromForm] UserRequest userRequest, [FromHeader] string x) 
    {
        return $"Nome: {userRequest.Name}, E-mail: {userRequest.Email}, x: {x}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
