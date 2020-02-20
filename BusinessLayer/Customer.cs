using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fixed_Deposit_Interest_Core_Web_App.BusinessLayer
{
    //Bank customer
    public class Customer
    {
        //Customer id 
        public int Id { get; set; }

        //name of the customer
        public string CustomerName { get; set; }

        //Customer identification 
        public string CustomerNumber { get; set; }

        //Bank id foreign key
        public int BankId { get; set; }

        //Bank link
        public Bank Bank { get; set; }

        //Customer display id 
        public string CustomerDisplayId  {

            get {

                return Bank.BankName + "-" + CustomerName;
            }
}

    }
}
