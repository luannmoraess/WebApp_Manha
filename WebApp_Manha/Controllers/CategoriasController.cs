using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;
using WebApp_Manha.Models;

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
        public IActionResult SalvarDados(CategoriaViewModel dados)
        {
            Categoria entidade = new Categoria();
            entidade.Nome = dados.Nome;
            entidade.Id = dados.Id;
            //entidade.Ativo = dados.Ativo == "on" ? true : false;
            entidade.Ativo = dados.Ativo;

            contexto.Categorias.Add(entidade);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
