using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;

namespace WebApp_Manha.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;

        public CategoriasController(Contexto _db)
        {
            contexto = _db;
        }

        public IActionResult Lista()
        {
            return View( contexto.Categorias.ToList() );
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(Categoria dados)
        {
            contexto.Categorias.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
