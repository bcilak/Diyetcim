using BitirmeDeneme.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeDeneme.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext context;
        public AccountController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult KayitDanisan()
        {
            return View();
        }
        public async Task<IActionResult> Register(Request model)
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}
