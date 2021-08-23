using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstWebApplication.Models;

namespace FirstWebApplication.Controllers
{
    public class BankCustomerController : Controller
    {
        private readonly BankCustomerDetails _context;

        public BankCustomerController(BankCustomerDetails context)
        {
            _context = context;
        }

        // GET: BankCustomer
        public async Task<IActionResult> Index()
        {
            return View(await _context.bankCustomers.ToListAsync());
        }

        // GET: BankCustomer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankCustomer = await _context.bankCustomers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (bankCustomer == null)
            {
                return NotFound();
            }

            return View(bankCustomer);
        }

        // GET: BankCustomer/Create
        public IActionResult AddOrEdit(int id=0)
        {
            return View(new BankCustomer());
        }

        // POST: BankCustomer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CustomerId,Name,Address,Age,Gender,OpeningBalance")] BankCustomer bankCustomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankCustomer);
        }

        // GET: BankCustomer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankCustomer = await _context.bankCustomers.FindAsync(id);
            if (bankCustomer == null)
            {
                return NotFound();
            }
            return View(bankCustomer);
        }

        // POST: BankCustomer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Name,Address,Age,Gender,OpeningBalance")] BankCustomer bankCustomer)
        {
            if (id != bankCustomer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankCustomerExists(bankCustomer.CustomerId))
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
            return View(bankCustomer);
        }

        // GET: BankCustomer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankCustomer = await _context.bankCustomers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (bankCustomer == null)
            {
                return NotFound();
            }

            return View(bankCustomer);
        }

        // POST: BankCustomer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bankCustomer = await _context.bankCustomers.FindAsync(id);
            _context.bankCustomers.Remove(bankCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankCustomerExists(int id)
        {
            return _context.bankCustomers.Any(e => e.CustomerId == id);
        }
    }
}
