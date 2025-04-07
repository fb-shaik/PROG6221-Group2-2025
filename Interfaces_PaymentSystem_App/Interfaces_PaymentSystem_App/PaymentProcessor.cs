using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PaymentSystem_App
{
    // PaymentProcessor class that processes payments using a selected payment method
    class PaymentProcessor
    {
        public readonly IPayment paymentMethod; // Stores the selected payment method

        // Constructor that accepts an IPayment instance (Dependency Injection)
        public PaymentProcessor(IPayment paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        // Calls the Pay method of the selected payment method
        public void ProcessPay(double amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
