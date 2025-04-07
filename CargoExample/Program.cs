using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Cargo with English parameters
            Cargo cargo1 = new Cargo(
                cargoID: "TR123456789",
                recipientName: "Jane Dave",
                recipientAddress: "USA, Texas",
                senderName: "Fethi Öcalan",
                senderAddress: "Ankara, Çankaya",
                weight: 2.5,
                status: "In Transit",
                shippingDate: new DateTime(2025, 4, 7)
            );

            // Displaying cargo information
            cargo1.ShowInformation();

            // Updating the cargo status
            cargo1.UpdateStatus("Delivered");

            // Changing the shipping date to the current date and time
            cargo1.ChangeShippingDate(DateTime.Now);

            // Displaying the weight of the cargo
            Console.WriteLine("Weight: " + cargo1.CalculateWeight() + " kg");

            // Displaying the cargo tracking number
            Console.WriteLine("Cargo Tracking Number: " + cargo1.GetTrackingNumber());

            // Displaying updated cargo information
            cargo1.ShowInformation();
        }
    }
}
