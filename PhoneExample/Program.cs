using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Phone myPhone = new Phone("Samsung", "A16", "Space gray",4000.0,16,965);
            myPhone.PhoneCall("05394512763");


            myPhone.ShowInformation();
            myPhone.UpdatePrice(5000);

            myPhone.UpdateMemory(32);

            myPhone.ShowInformation();


            myPhone.UpdateBatteryCapacity(5000);

            myPhone.ShowInformation();
            Console.ReadLine();


        }
    }
}
