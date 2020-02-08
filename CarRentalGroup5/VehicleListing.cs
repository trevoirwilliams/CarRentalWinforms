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
    public partial class VehicleListing : Form
    {
        private readonly CarRentalDB5Entities _db;
        public VehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalDB5Entities();
        }

        private void VehicleListing_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars.ToList();
            gvCarList.DataSource = cars;
            gvCarList.Columns[0].HeaderText = "ID";
            gvCarList.Columns[1].HeaderText = "NAME";
        }
    }
}
