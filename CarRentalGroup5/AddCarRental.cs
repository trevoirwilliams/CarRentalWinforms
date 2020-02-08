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
    public partial class AddCarRental : Form
    {
        private readonly CarRentalDB5Entities _carRentalDB5Entities;
        public AddCarRental()
        {
            InitializeComponent();
            _carRentalDB5Entities = new CarRentalDB5Entities();
        }

        //Button Click event on our submit button
        private void button1_Click(object sender, EventArgs e)
        {
            //Exception handling can be used to help with validations and error handling. 
            try
            {
                //Collect all values from the controls and store them in variables.
                string customerName = txtCustomerName.Text;
                double cost = Convert.ToDouble(txtCost.Text);
                //Retrieve Date values from the date picker controls
                var dateRented = dtRentDate.Value;
                var dateReturned = dtReturnDate.Value;
                //Use the keyword var to declare a more generic variable
                //whose data type is determined by the value being assigned. 
                var typeOfCar = cbCarList.Text;
                //Valid state flag. This is used to track of the data entered is valid or not. 
                var isValid = true;

                // Adding validations to the form input.
                if (String.IsNullOrEmpty(customerName)
                    || dateRented == null
                    || String.IsNullOrWhiteSpace(typeOfCar))
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
                //if(isValid == true) can also be written as follows. 
                if (isValid)
                {
                    RentalRecord record = new RentalRecord();
                    record.cost = (decimal)cost;
                    record.customerName = customerName;
                    record.rentDate = dateRented;
                    record.returnDate = dateReturned;
                    record.typeOfCarId = (int)cbCarList.SelectedValue;

                    _carRentalDB5Entities.RentalRecords.Add(record);
                    _carRentalDB5Entities.SaveChanges();

                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                    $"Cost: {cost}\n\r" +
                    $"Date Rented: {dateRented}\n\r" +
                    $"Date Returned: {dateReturned}\n\r" +
                    $"Type Of Car: {typeOfCar}");

                    txtCost.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //We comment throw to prevent the application from terminating. 
                //throw;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _carRentalDB5Entities.TypesOfCars.ToList();
            cbCarList.DisplayMember = "name";
            cbCarList.ValueMember = "id";
            cbCarList.DataSource = cars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create an object of the Window you intend to show
            MainWindow mainWindow = new MainWindow();
            //Call the Show() function from the object
            mainWindow.Show();
        }
    }
}
