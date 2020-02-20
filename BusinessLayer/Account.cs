using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fixed_Deposit_Interest_Core_Web_App.BusinessLayer
{
    //Account details 
    public class Account
    {
        //Account id
       public  int Id { get; set; }

        //Account number
       public string AccountNumber { get; set;  }

        //Account balance 
       public double Balance { get; set; }

        //Customer id foriegn key
       public int CustomerId { get; set; }

        //Customer link
       public Customer Customer { get; set; }

        //Combined  id for display purpose
        [NotMapped]
       public string AccountDisplayId { get {


                return Customer.CustomerName + "-" + AccountNumber;
            
            } }
     



    }
}
