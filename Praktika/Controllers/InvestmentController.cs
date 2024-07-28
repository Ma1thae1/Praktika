using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Praktika.Data;
using Microsoft.EntityFrameworkCore;

namespace Praktika.Controllers
{
    public class InvestmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvestmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Investments.Include(i => i.Company).Include(i => i.User).ToListAsync());
        }

        
        // GET: InvestmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvestmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvestmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvestmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvestmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvestmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvestmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
