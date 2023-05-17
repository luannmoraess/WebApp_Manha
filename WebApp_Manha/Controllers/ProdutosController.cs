using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }


        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            NovoProdutoModelView model = new NovoProdutoModelView();
            model.ListaCategorias = db.Categorias.ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult SalvarDados(Produtos dados)
        {
            db.Produtos.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
