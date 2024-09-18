using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NomeDoSeuProjeto.Models;
using PartialView.Models;


namespace NomeDoSeuProjeto.Controllers;

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

    [HttpGet]
    public IActionResult praticaControlerView()
    {
        var listaModelObject = new List<PartialView.Models.Model>();

        var InstanciandoModel = new Model();
        InstanciandoModel.nome = "cleber";
        InstanciandoModel.idade = 24;
        InstanciandoModel.email = "Cleber@hdsdfsdfsdf.com";  
        listaModelObject.Add(InstanciandoModel);

        var InstanciandoLista2 = new Model();
        InstanciandoLista2.nome = "na";
        InstanciandoLista2.idade = 54;
        InstanciandoLista2.email = "Clçejkwbekbsw@adfsadfs.com";
        listaModelObject.Add(InstanciandoLista2);

        var listandoObjetosAgora = new ListaDeModel();
        listandoObjetosAgora.cor = "blue";
        listandoObjetosAgora.displaycss = "inline-block";
        return PartialView("_olaMundo" ,listandoObjetosAgora);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
