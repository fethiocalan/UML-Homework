using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace CarProject
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int originalYPosition;
        private void Form2_Load(object sender, EventArgs e)
        {
            originalYPosition = CarImage_.Top;
        }

        public void displayCarInfo(Cars car)
        {
            // Check if the car properties are not null or empty before assigning
            carBrand.Text = string.IsNullOrEmpty(car.Brand) ? "Unknown" : car.Brand;
            carLabel.Text = string.IsNullOrEmpty(car.Modal) ? "Unknown" : car.Modal;
            carColor.Text = string.IsNullOrEmpty(car.Color) ? "Unknown" : car.Color;
            carYear.Text = car.Year > 0 ? car.Year.ToString() : "Unknown";
            carPrice.Text = car.Price > 0 ? car.Price.ToString("C") : "Unknown";

            // Check if the image path is valid before attempting to load
            if (!string.IsNullOrEmpty(car.CarImage) && File.Exists(car.CarImage))
            {
                try
                {
                    CarImage_.Image = Image.FromFile(car.CarImage); // Load the image
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                CarImage_.Image = null; // Fallback if the image path is invalid or empty
                MessageBox.Show("Image not found or invalid.");
            }
        }
        private double time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            time += 0.05;

            double newYPosition = Math.Sin(time) * 10;

            CarImage_.Top = originalYPosition+28 + (int)newYPosition;

        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
