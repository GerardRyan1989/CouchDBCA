using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouchDBCA
{
    public partial class AddCar : Form
    {

        List<ServiceHistory> servHistory = new List<ServiceHistory>();

        public AddCar()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            List<string> carExtras = new List<string>();
            carExtras.Add(txtExtras.Text);


            Car car = new Car
            {
                _id = txtRegistration.Text,
                Make = txtMake.Text,
                Model = txtModel.Text,
                EngineSize = Convert.ToDouble(txtEngineSize.Text),
                FuelType = txtFuelType.Text,
                Extras = carExtras,
                Transmission =txtTransmission.Text,
                ServHistory = servHistory,
                SafetyRating = Convert.ToInt16(txtSafetyRating.Text),
                numofOwners= Convert.ToInt16(txtNumOfOwners.Text)

            };

            RestClientPost rest = new RestClientPost();
            rest.postObject(car);
            servHistory.Clear();
            carExtras.Clear();
         
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

            int Miles = Convert.ToInt32(txtMilesServicedAt.Text);
            string Garage = txtGarage.Text;
            DateTime Date = Convert.ToDateTime(dtpServiceDate.Text);

            servHistory.Add(new ServiceHistory(Garage,Miles,Date));

            txtGarage.Text = "";
            txtMilesServicedAt.Text = "";
            dtpServiceDate.ResetText();
        }
    }
}
