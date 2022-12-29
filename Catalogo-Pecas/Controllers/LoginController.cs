using Catalogo_Pecas.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Catalogo_Pecas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(loginModel.Email == "amandaadmin@email.com" && loginModel.Senha == "654123")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["MensagemErro"] = $"Permissão não concedida. Por favor, tente novamente";
                }
                return View("Index");
            }
            catch (Exception)
            {
                TempData["MensagemErro"] = $"Dados inválidos. Por favor, tente novamente";
                return RedirectToAction("Index");
            }

        }
    }
}
