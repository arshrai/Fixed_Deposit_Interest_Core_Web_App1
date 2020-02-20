using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fixed_Deposit_Interest_Core_Web_App.BusinessLayer
{
    //Calculates accumulated balance from the compound interest
    public class CalculatedBalance
    {   
        
        public int Id { get; set; }

        //Account reference
        public Account Account { get; set; }

        //Accound id foriegn
        public int AccountId { get; set; }

        //Deposit  period
        public int NumberOfYears { get; set; }
        

        //Compound interest
        [NotMapped]
        public double TotalAccumulatedBalance { get {

                return Math.Round(Account.Balance * Math.Pow((1 + (Account.Customer.Bank.FixedDepositPercentage )/ 100), NumberOfYears ), 2);
            
            } }




    }
}
