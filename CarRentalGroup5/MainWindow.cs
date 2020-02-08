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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCarRental = new AddCarRental();
            addCarRental.MdiParent = this;
            addCarRental.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new VehicleListing();
            vehicleListing.MdiParent = this;
            vehicleListing.Show();
        }
    }
}
