using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaGerenciamentoEventos.Models;

namespace SistemaGerenciamentoEventos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // a view index lê essa chave para exibir o valor da mensagem
        ViewData["Mensagem"] = "Bem-indo ao sistema";
        return View();
    }

    // action recebe parametro pela: /home/Sobre/5
    public IActionResult Sobre(int? id)
    {
        // id pode ser nulo porque o trecho final da rota é opcional
        ViewBag.Versao = "1.0";
        ViewBag.ParametroId = id;
        return View();
    }

    //action recebe parametros via query string: /home/saudacao?nome.Kessia
    public IActionResult Saudacao(string nome)
    {
        ViewData["Nome"] = nome ?? "Visitante";
        return View();
    }
}
