using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.ColorPick.Picker;

namespace CarProject
{
    public class Cars
    {
        public string Brand { get; set; }
        public string Modal { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string CarImage { get; set; }
        // Constructor
        public Cars(string brand, string modal, string color, int year, double price,string carImage)
        {
            Brand = brand;
            Modal = modal;
            Color = color;
            Year = year;
            Price = price;
            CarImage = carImage;
        }
        public void CarInfo() {

            
        
        }
    }
}
