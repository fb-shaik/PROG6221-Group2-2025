using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PaymentSystem_App
{
    // Implementation of IPayment interface for Credit Card payments
    class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount:F2} using Credit Card.");
            //F2 - fixed point number set to 2 deciml places
            //useful for currency / financial values
            //if amount = 10.5 >>> print on screen will be 10.50
        }
    }
}
