using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PaymentSystem_App
{
    // Implementation of IPayment interface for PayPal payments
    class PayPalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount:F2} using PayPal.");
        }
    }
}
