using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fixed_Deposit_Interest_Core_Web_App.BusinessLayer;

namespace Fixed_Deposit_Interest_Core_Web_App.Models
{
    //Connects to the database
    public class Fixed_Deposit_Interest_Context : DbContext
    {
        public Fixed_Deposit_Interest_Context (DbContextOptions<Fixed_Deposit_Interest_Context> options)
            : base(options)
        {
        }

        public DbSet<Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Account> Account { get; set; }

        public DbSet<Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Bank> Bank { get; set; }

        public DbSet<Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.CalculatedBalance> CalculatedBalance { get; set; }

        public DbSet<Fixed_Deposit_Interest_Core_Web_App.BusinessLayer.Customer> Customer { get; set; }
    }
}
