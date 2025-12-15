using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {


        private readonly SellerService _context;

        // 2. Construtor para injetar a dependência
        public SellersController(SellerService context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.FindAll();
            return View(list);
        }
    }
}
