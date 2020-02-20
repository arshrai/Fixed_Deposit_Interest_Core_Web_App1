using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fixed_Deposit_Interest_Core_Web_App.BusinessLayer;
using Fixed_Deposit_Interest_Core_Web_App.Models;

namespace Fixed_Deposit_Interest_Core_Web_App.Pages.CalculatedBalances
{
    public class IndexModel : PageModel
    {
        private readonly Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context _context;

        public IndexModel(Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context context)
        {
            _context = context;
        }

        public IList<CalculatedBalance> CalculatedBalance { get;set; }

        public async Task OnGetAsync()
        {
            CalculatedBalance = await _context.CalculatedBalance
                .Include(c => c.Account).Include(c=>c.Account.Customer).Include(c => c.Account.Customer.Bank).ToListAsync();
        }
    }
}
