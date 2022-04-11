using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.DataAcess
{
    public class Transaction
    {
       public int Id { get; set; }

       public double Amount { get; set; }

       public DateTime PayDate { get; set; }

    }
}
