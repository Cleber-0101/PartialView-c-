using System.Data.SqlTypes;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NomeDoSeuProjeto.Models;
using PartialView.Models;
using PartialView.Repositories;


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

    [HttpPost]
    public async  Task<IActionResult> CadastrandoUsuario([FromBody] Model model)
    {
        var repository = new RepositoryUser();
        await repository.InsertUser(model);
        return Json(new { success = true, message = "Usuário cadastrado com sucesso!" });
    }

    [HttpGet]
    public IActionResult praticaControlerView()
    {
        var listaModelObject = new List<PartialView.Models.Model>();

        var InstanciandoModel = new Model();
        InstanciandoModel.nome = "cleber";
        InstanciandoModel.idade = 24;
        InstanciandoModel.email = "veles@hotmail.com";
        listaModelObject.Add(InstanciandoModel);

        var InstanciandoLista2 = new Model();
        InstanciandoLista2.nome = "magal";
        InstanciandoLista2.idade = 54;
        InstanciandoLista2.email = "magal@hotmail.com";
        listaModelObject.Add(InstanciandoLista2);

        var InstanciandoLista3 = new Model();
        InstanciandoLista3.nome = "evandro";
        InstanciandoLista3.idade = 54;
        InstanciandoLista3.email = "evandro@hotmail.com";
        listaModelObject.Add(InstanciandoLista3);

        var listandoObjetosAgora = new ListaDeModel();
        listandoObjetosAgora.cor = "green";
        listandoObjetosAgora.displayCSS = "inline-block";
        listandoObjetosAgora.lista = listaModelObject;
        return PartialView("_olaMundo", listandoObjetosAgora);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
