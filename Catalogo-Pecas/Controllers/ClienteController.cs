using Catalogo_Pecas.Models;
using Catalogo_Pecas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Catalogo_Pecas.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Clientes> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Cadastrar(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Clientes oCliente = oClienteService.oRepositoryCliente.SelecionarPK(Id);
            return View(oCliente);
        }
    }
}
