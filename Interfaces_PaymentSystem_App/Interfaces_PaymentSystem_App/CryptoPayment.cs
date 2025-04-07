using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PaymentSystem_App
{
    // Implementation of IPayment interface for Cryptocurrency payments
    class CryptoPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount:F2} using CryptoPayment.");
        }
    }
}
