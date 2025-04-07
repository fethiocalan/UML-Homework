using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors;

namespace CarProject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        string fileName = "";
        private void CarImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "PNG | *.png | JPG | *.jpg | JPEG | *.jpeg | All Files | *.*";
            
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                CarImage.Image = Image.FromFile(fileOpen.FileName);
                fileName = fileOpen.FileName;
            }
            fileOpen.Dispose();
        }


        private double time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            time += 0.05;

            double newYPosition = Math.Sin(time) * 15;

            CarImage.Top = originalYPosition + (int)newYPosition;

        }
        private int originalYPosition;
        private void Form1_Load(object sender, EventArgs e)
        {
            originalYPosition = CarImage.Top;
            panel2.Visible = false;
        }
        Form2 frm2 = new Form2();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = CarBrand.Text;
                string modal = CarModal.Text;
                string color = CarColor.Text;

                // Validate and parse Year
                int year;
                if (!int.TryParse(CarYear.Text, out year))
                {
                    MessageBox.Show("Please enter a valid year.");
                    return;
                }

                // Validate and parse Price
                double price;
                if (!double.TryParse(CarPrice.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                // Create a new car object
                Cars myCar = new Cars(brand, modal, color, year, price,fileName);

                // Optionally, display a success message or add the car to a list/grid
                panel2.Visible = true;
             
                frm2.displayCarInfo(myCar);



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Show();
        }
    }
}
