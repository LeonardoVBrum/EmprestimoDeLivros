using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
