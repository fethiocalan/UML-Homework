using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneExample
{
    class Phone
    {
        private string Brand;
        private string Modal;
        private string Color;
        private double Price;
        private int Memory;
        private int batteryCapacity;

        public Phone(string Brand, string Modal, string Color, double Price, int Memory, int BatteryCapacity) { 
            this.Brand = Brand;
            this.Modal = Modal;
            this.Color = Color;
            this.Price = Price;
            this.Memory = Memory;
        
        
        }
        public void ShowInformation() {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Brand = "+Brand);
            Console.WriteLine("Modal = "+Modal);
            Console.WriteLine("Color = "+Color);
            Console.WriteLine("Price = "+Price+" $");
            Console.WriteLine("Memory = "+Memory+" GB");
            Console.WriteLine("Battery Capacity = "+batteryCapacity+" mAh");
            Console.WriteLine("------------------------------");
        }

        public void UpdatePrice(double newPrice) {
            Price = newPrice;
            Console.WriteLine("New Price = "+Price+" $");


        
        }
        public void UpdateMemory(int newMemory)
        {
            Memory = newMemory;
            Console.WriteLine("New Battery Capacity = " + Memory + " GB");

        }
        public void UpdateBatteryCapacity(int Capacity)
        {
            
            Console.WriteLine("The previous battery capacity = "+batteryCapacity);
            batteryCapacity = Capacity;
            Console.WriteLine("The phone's battery Capacity has been updated = " + batteryCapacity + " mAh");

        }

        public void PhoneCall(string number) {

            Console.WriteLine(number+" is Ringing...");
        }

    }
}
