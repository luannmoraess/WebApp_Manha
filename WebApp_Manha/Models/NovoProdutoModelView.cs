using WebApp_Manha.Entidades;

namespace WebApp_Manha.Models
{
    public class NovoProdutoModelView : Produtos
    {
        public NovoProdutoModelView()
        {
            ListaCategorias = new List<Categoria>();
        }

        public List<Categoria> ListaCategorias { get; set; }
    }
}
