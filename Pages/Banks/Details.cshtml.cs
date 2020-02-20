﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fixed_Deposit_Interest_Core_Web_App.BusinessLayer;
using Fixed_Deposit_Interest_Core_Web_App.Models;

namespace Fixed_Deposit_Interest_Core_Web_App.Pages.Banks
{
    public class DetailsModel : PageModel
    {
        private readonly Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context _context;

        public DetailsModel(Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context context)
        {
            _context = context;
        }

        public Bank Bank { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bank = await _context.Bank.FirstOrDefaultAsync(m => m.Id == id);

            if (Bank == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
