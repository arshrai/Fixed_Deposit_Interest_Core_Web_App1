﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fixed_Deposit_Interest_Core_Web_App.BusinessLayer;
using Fixed_Deposit_Interest_Core_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Fixed_Deposit_Interest_Core_Web_App.Pages.CalculatedBalances
{
    public class CreateModel : PageModel
    {
        private readonly Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context _context;

        public CreateModel(Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountId"] = new SelectList(_context.Account.Include(ac =>ac.Customer).ToList(), "Id", "AccountDisplayId");
            return Page();
        }

        [BindProperty]
        public CalculatedBalance CalculatedBalance { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CalculatedBalance.Add(CalculatedBalance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
