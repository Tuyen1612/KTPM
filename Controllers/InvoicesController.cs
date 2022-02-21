using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191373_0306191333_0306191376_0306191482.Data;
using _0306191373_0306191333_0306191376_0306191482.Models;

namespace _0306191373_0306191333_0306191376_0306191482.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly ShopContext _context;

        public InvoicesController(ShopContext context)
        {
            _context = context;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            var lstInvoices = _context.Invoides.Include(i => i.Account).ToList();
            return View(lstInvoices);
        }
        // doanh thu theo ngày
        public async Task<IActionResult> revenue()
        { 
            var lstDayrevenue = _context.Invoides.ToList();
            return View(lstDayrevenue);
        }
        // hóa đơn trong tuần
        public async Task<IActionResult> New()
        {
            int temp = (int)DateTime.Now.DayOfWeek; //lấy ra thứ của ngày hôm nay ví dụ thứ 3 
            DateTime top =   DateTime.Now.AddDays(8-temp);
            DateTime bot = DateTime.Now.AddDays(-( temp -2));
            var lstInvoices = _context.Invoides
                .Where(i => i.IssueDate.Year >= bot.Year)
                .Where(i => i.IssueDate.Month >= bot.Month)
                .Where(i => i.IssueDate.Day >= bot.Day)
                .Where(i => i.IssueDate.Year <= top.Year)
                .Where(i => i.IssueDate.Year >= top.Month)
                .Where(i => i.IssueDate.Year >= top.Day)
                .ToList();
            return View(lstInvoices);
        }

        // GET: Invoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoides
                .Include(i => i.Account)
                .FirstOrDefaultAsync(m => m.id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        //tien-dev
        public async Task<IActionResult> InvoiceDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceDetails = await _context.InvoiceDetails.Include(i =>i.Product)
                .Where(i => i.InvoiceId == id).ToListAsync<InvoiceDetail>();

            if (invoiceDetails == null)
            {   
                return NotFound();
            }

            return View(invoiceDetails);
        }

        //tien-dev 

        // GET: Invoices/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "id", "Fullname");
            return View();
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Code,IssueDate,ShippingAddress,ShippingPhone,Total,AccountId,Status")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "id", "Fullname", invoice.AccountId);
            return View(invoice);
        }

        // GET: Invoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoides.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "id", "Fullname", invoice.AccountId);
            return View(invoice);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Code,IssueDate,ShippingAddress,ShippingPhone,Total,AccountId,Status")] Invoice invoice)
        {
            if (id != invoice.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoice.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "id", "Fullname", invoice.AccountId);
            return View(invoice);
        }

        // GET: Invoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoides
                .Include(i => i.Account)
                .FirstOrDefaultAsync(m => m.id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoice = await _context.Invoides.FindAsync(id);
            _context.Invoides.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoides.Any(e => e.id == id);
        }
    }
}
