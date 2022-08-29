using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteAvaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LoginAspNetCoreEFCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _contexto;

        public LoginController(Contexto contexto)
        {
            _contexto = contexto;
        }
        

        public IActionResult Index()
        {
            
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string Nome, string Senha, bool manterlogado)
        {
            Usuarios usuario = _contexto.Usuarios.AsNoTracking().FirstOrDefault(x => x.Nome == Nome && x.Senha == Senha);

            if (usuario != null)
            {
                return  Validado(Nome);
              
            }

            return Json(new { Msg = "Usuario nao encontrado! Verifique suas credenciais!" });
        }

        
        public IActionResult Validado(string Nome)
        {
            if (Nome == "master")
            {
               return RedirectToAction("Index", "Home");
            }
               return RedirectToAction("Privacy", "Home");
        }

    }
}
