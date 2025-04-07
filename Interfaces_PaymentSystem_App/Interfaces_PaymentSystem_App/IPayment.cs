using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PaymentSystem_App
{
    interface IPayment
    // Interface defining a contract for different payment methods
    {//hold properties & methods
     //template space to be used else-where
        void Pay(double amount);//has no implementation
    }

    //Syntax: interface IName
    //{
    //      methods (these methods can be seen as abstract)
    //}
}
