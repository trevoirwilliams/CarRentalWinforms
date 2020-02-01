using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalGroup5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtCustomerName.Text;
                double cost = Convert.ToDouble(txtCost.Text);
                var dateRented = dtRentDate.Value;
                var dateReturned = dtReturnDate.Value;
                //Use the keyword var to declare a more generic variable
                //whose data type is determined by the value being assigned. 
                var typeOfCar = cbCarList.Text;
                var isValid = true;

                // Adding validations to the form input
                if (String.IsNullOrEmpty(customerName)
                    || dateRented == null
                    || String.IsNullOrEmpty(typeOfCar))
                {
                    isValid = false;
                    MessageBox.Show("Incomplete");
                }
                if (dateRented > dateReturned)
                {
                    isValid = false;
                    MessageBox.Show("Invalid Date Entered for Return " +
                        "Date");
                }
                //if(isValid == true)
                if (isValid)
                {
                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                    $"Cost: {cost}\n\r" +
                    $"Date Rented: {dateRented}\n\r" +
                    $"Date Returned: {dateReturned}\n\r" +
                    $"Type Of Car: {typeOfCar}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
            
        }
    }
}
