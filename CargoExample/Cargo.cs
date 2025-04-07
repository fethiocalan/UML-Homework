using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoExample
{
    class Cargo
    {
        private string CargoID;
        private string RecipientName;
        private string RecipientAddress;
        private string SenderName;
        private string SenderAddress;
        private double Weight;
        private string Status;
        private DateTime ShippingDate;

        // Constructor
        public Cargo(string cargoID, string recipientName, string recipientAddress, string senderName,
                     string senderAddress, double weight, string status, DateTime shippingDate)
        {
            CargoID = cargoID;
            RecipientName = recipientName;
            RecipientAddress = recipientAddress;
            SenderName = senderName;
            SenderAddress = senderAddress;
            Weight = weight;
            Status = status;
            ShippingDate = shippingDate;
        }

        // Show Information
        public void ShowInformation()
        {
            Console.WriteLine("\n\n--------------------------------------------");
            Console.WriteLine("Cargo ID: " + CargoID);
            Console.WriteLine("Recipient Name: " + RecipientName);
            Console.WriteLine("Recipient Address: " + RecipientAddress);
            Console.WriteLine("Sender Name: " + SenderName);
            Console.WriteLine("Sender Address: " + SenderAddress);
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Shipping Date: " + ShippingDate.ToShortDateString());
            Console.WriteLine("--------------------------------------------\n\n");
        }

        // Update Status
        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Console.WriteLine("Status updated: " + Status);
        }

        // Change Shipping Date
        public void ChangeShippingDate(DateTime newDate)
        {
            ShippingDate = newDate;
            Console.WriteLine("Shipping date updated: " + ShippingDate.ToShortDateString());
        }

        // Calculate Weight
        public double CalculateWeight()
        {
            return Weight;
        }

        // Show Tracking Number
        public string GetTrackingNumber()
        {
            return CargoID;
        }
    }
}
