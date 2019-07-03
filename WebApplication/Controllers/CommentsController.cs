using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CommentsController : Controller
    {
        private readonly WebApplicationContext _context;

        public CommentsController(WebApplicationContext context)
        {
            _context = context;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            CommentsViewModel vm = new CommentsViewModel();
            vm.Contents = await _context.Content.OrderByDescending(column => column.CreateAt).ToListAsync();
            vm.Content = new Content();
            return View(vm);
        }

        // POST: Comments/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CommentsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //Insert
                vm.Content.CreateAt = DateTime.Now;
                _context.Add(vm.Content);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            vm.Contents = await _context.Content.OrderByDescending(column => column.CreateAt).ToListAsync();
            return View(vm);
        }
    }
}
