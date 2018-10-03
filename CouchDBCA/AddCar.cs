using DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CouchDBCA
{
    public partial class AddCar : Form
    {

        List<ServiceHistory> servHistory = new List<ServiceHistory>();

        public AddCar()
        {
            InitializeComponent();
            this.Size = new Size(1000, 820);
            cboExtras.Items.Add("Air Con, Leather Seats");
            cboExtras.Items.Add("Air Con, Alloy wheels");
            cboExtras.Items.Add("Air Con, Alloy Wheels, Leather seats");
            cboExtras.Items.Add("Alloy Wheels");
            cboExtras.Items.Add("Leather Seats");
            cboExtras.Items.Add("Air Con");

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            List<string> carExtras = new List<string>();


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
                numofOwners= Convert.ToInt16(txtNumOfOwners.Text),
                PrevOwner = new PreviousOwners
                {
                    Name = txtPreviousOwnerName.Text,
                    Address = txtPreviousOwnerAddress.Text,
                    YearsOwned = Convert.ToInt16(txtYearsOwned.Text)
                }
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
