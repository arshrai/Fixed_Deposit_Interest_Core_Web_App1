using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fixed_Deposit_Interest_Core_Web_App.BusinessLayer
{
    //Bank information
    public class Bank
    {
        //Bank id 
        public int Id { get; set; }

        //Bank name
        public string BankName { get; set; }

        //Bank Fixed deposit percentage interest per annum
        public double  FixedDepositPercentage { get; set; }
    }
}
