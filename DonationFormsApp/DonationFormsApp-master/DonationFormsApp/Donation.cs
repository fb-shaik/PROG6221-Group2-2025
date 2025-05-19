using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationFormsApp
{
    internal class Donation
    {
        public Donation(int donationId, double amount, string cause, int donorId)
        {
            DonationId = donationId;
            Amount = amount;
            Cause = cause;
            DonorId = donorId;
        }

        public int DonationId { get; set; }
        public double Amount { get; set; }
        public string Cause { get; set; }
        public int DonorId { get; set; }
        
        public override bool Equals(object? obj)
        {
            //Check for null and ensure that its the same type
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Donation d = (Donation) obj;
                return Cause.Equals(d.Cause) &&
                Amount == d.Amount &&
                DonorId == d.DonorId;
            }            
        }        

        public override string? ToString()
        {
            return DonationId + " - " + Amount + " - " + Cause + " - " + DonorId;
        }
        
    }
}
