using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fixed_Deposit_Interest_Core_Web_App.BusinessLayer;
using Fixed_Deposit_Interest_Core_Web_App.Models;

namespace Fixed_Deposit_Interest_Core_Web_App.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context _context;

        public IndexModel(Fixed_Deposit_Interest_Core_Web_App.Models.Fixed_Deposit_Interest_Context context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }

        public async Task OnGetAsync()
        {
            Account = await _context.Account
                .Include(a => a.Customer).Include(a=>a.Customer.Bank).ToListAsync();
        }
    }
}
