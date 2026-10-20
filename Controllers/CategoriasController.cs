using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult Index()
        {List<Categorias> produtos = new List<Categorias>
            {
                new Categorias(1, "Informática", "Computadores e componentes", "True"),
                new Categorias(2, "Periféricos", "Mouse, teclado e acessórios", "True"),
                new Categorias(3, "Áudio", "caixas e microfones", "True"),
                new Categorias(4, "Monitores", "Telas e monitores", "True"),  
                new Categorias(4, "Descontinuados", "Categorias fora de uso", "False"),  
            };
            return View();}
    }
}