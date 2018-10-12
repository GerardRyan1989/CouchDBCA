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
            this.Size = new Size(900, 700);
            cboExtras.Items.Add("Air Con, Leather Seats");
            cboExtras.Items.Add("Air Con, Alloy wheels");
            cboExtras.Items.Add("Air Con, Alloy Wheels, Leather Seats");
            cboExtras.Items.Add("Alloy Wheels");
            cboExtras.Items.Add("Leather Seats");
            cboExtras.Items.Add("Air Con");
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            List<string> extrasList = new List<string>();
            Car car;

            if (cboExtras.SelectedItem != null)
            {
                switch (cboExtras.SelectedItem.ToString())
                {
                    case "Air Con, Leather Seats":
                        extrasList.Add("Air Con");
                        extrasList.Add("Leather Seats");
                        break;
                    case "Air Con, Alloy Wheels":
                        extrasList.Add("Air Con");
                        extrasList.Add("Alloy Wheels");
                        break;
                    case "Air Con, Alloy Wheels, Leather Seats":
                        extrasList.Add("Air Con");
                        extrasList.Add("Alloy Wheels");
                        extrasList.Add("Leather Seats");
                        break;
                    case "Air Con":
                        extrasList.Add("Air Con");
                        break;
                    case "Alloy Wheels":
                        extrasList.Add("Alloy Wheels");
                        break;
                    case "Leather Seats":
                        extrasList.Add("Leather Seats");
                        break;
                }

                try
                {
                    car = new Car
                    {
                        _id = txtRegistration.Text.ToUpper(),
                        Make = txtMake.Text.ToUpper(),
                        Model = txtModel.Text.ToUpper(),
                        EngineSize = Convert.ToDouble(txtEngineSize.Text),
                        FuelType = txtFuelType.Text.ToUpper(),
                        Extras = extrasList,
                        Transmission = txtTransmission.Text.ToUpper(),
                        ServHistory = servHistory,
                        SafetyRating = Convert.ToInt32(txtSafetyRating.Text),
                        numofOwners = Convert.ToInt32(txtNumOfOwners.Text),
                        SalesPrices = Convert.ToInt32(txtSalesPrice.Text),
                        mileage = Convert.ToInt16(txtMileage.Text),
                        PrevOwner = new PreviousOwners
                        {
                            Name = txtPreviousOwnerName.Text.ToUpper(),
                            Address = txtPreviousOwnerAddress.Text.ToUpper(),
                            YearsOwned = Convert.ToInt16(txtYearsOwned.Text)
                        }
                    };

                    RestClientPost rest = new RestClientPost();
                    rest.postObject(car);
                    servHistory.Clear();
                    extrasList.Clear();
                    MessageBox.Show("Car Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check all fields are filled in correctly");
                }
            }
            else
            {
                MessageBox.Show("Please choose a value for extras");
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

            string Miles = txtServicedMiles.Text;
            string Garage = txtServiceGarage.Text;
            DateTime Date = Convert.ToDateTime(dtpServiceDate.Text);

            servHistory.Add(new ServiceHistory(Garage,Miles,Date));

            txtGarage.Text = "";
            txtMilesServicedAt.Text = "";
            dtpServiceDate.ResetText();
        }
    }
}
