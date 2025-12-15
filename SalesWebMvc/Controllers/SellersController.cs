using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {


        private readonly SalesWebMvcContext _context;

        // 2. Construtor para injetar a dependência
        public SellersController(SalesWebMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // 3. Buscar todos os vendedores do banco e passar para a View
            var list = _context.Seller.ToList();
            return View(list);
        }
    }
}
