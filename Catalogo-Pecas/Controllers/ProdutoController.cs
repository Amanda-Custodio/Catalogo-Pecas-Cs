using Catalogo_Pecas.Models;
using Catalogo_Pecas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Catalogo_Pecas.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoService oProdutoService = new ProdutoService();

        public IActionResult Index()
        {
            List<Produtos> oListProduto = oProdutoService.oRepositoryProduto.SelecionarTodos();
            return View(oListProduto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produtos produto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oProdutoService.oRepositoryProduto.Cadastrar(produto);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            Produtos oProduto = oProdutoService.oRepositoryProduto.SelecionarPK(Id);
            return View(oProduto);
        }

        [HttpPost]
        public IActionResult Edit(Produtos produto)
        {
            Produtos oProduto = oProdutoService.oRepositoryProduto.Alterar(produto);

            int id = oProduto.Id;
            return RedirectToAction("Index");
        }
    }
}
