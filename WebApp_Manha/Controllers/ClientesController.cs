using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            ClienteViewModel novo = new ClienteViewModel();
            novo.Nome = "Fernando Graciano";
            novo.Id = 10;
            novo.Telefone = "16991340447";

            ClienteViewModel novo2 = new ClienteViewModel();
            novo.Nome = "Julio Garcia";
            novo.Id = 5;
            novo.Telefone = "169874563214";

            List<ClienteViewModel> lista = new List<ClienteViewModel>();
            lista.Add(novo);
            lista.Add(novo2);

            return View(lista);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "O campo nome não pode estar em branco";
            }

            if (string.IsNullOrEmpty(Telefone))
            {
                TempData["Erro"] = "O campo Telefone não pode estar em branco";
            }
            return View();
        }


        public IActionResult Editar(int id)
        {
            return View();
        }
        public IActionResult Excluir(int id)
        {
            return View();
        }
        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
