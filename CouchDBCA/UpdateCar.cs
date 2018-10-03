using DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CouchDBCA
{
    public partial class UpdateCar : Form
    {
        List<ServiceHistory> servHistory;
        Car returnedCar;

        public UpdateCar()
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string reg = txtReg.Text;
           
            RestClientGet restGet = new RestClientGet();
            returnedCar = await restGet.GetObject(reg);



            txtRegistration.Text = returnedCar._id.ToString();
            txtMake.Text = returnedCar.Make;
            txtModel.Text = returnedCar.Model;
            txtEngineSize.Text = returnedCar.EngineSize.ToString();
            cboExtras.Text = returnedCar.Extras.ToString();
            txtFuelType.Text = returnedCar.FuelType;
            txtMileage.Text = returnedCar.mileage.ToString();
            txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
            txtPreviousOwnerAddress.Text = returnedCar.PrevOwner.Address;
            txtPreviousOwnerName.Text = returnedCar.PrevOwner.Name;
            txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
            txtYearsOwned.Text = returnedCar.PrevOwner.YearsOwned.ToString();
            txtTransmission.Text = returnedCar.Transmission;
            txtSafetyRating.Text = returnedCar.SafetyRating.ToString();
            servHistory = returnedCar.ServHistory;
    

         

            
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            List<string> extrasTempList = new List<string>();
            
            Car car = new Car
            {
                _id = txtRegistration.Text,
                _rev = returnedCar._rev,
                Make = txtMake.Text,
                Model = txtModel.Text,
                EngineSize = Convert.ToDouble(txtEngineSize.Text),
                FuelType = txtFuelType.Text,
                Extras = extrasTempList,
                Transmission = txtTransmission.Text,
                ServHistory = servHistory,
                SafetyRating = Convert.ToInt16(txtSafetyRating.Text),
                numofOwners = Convert.ToInt16(txtNumOfOwners.Text),
                PrevOwner = new PreviousOwners
                {
                    Name = txtPreviousOwnerName.Text,
                    Address = txtPreviousOwnerAddress.Text,
                    YearsOwned = Convert.ToInt16(txtYearsOwned.Text)
                }
            };
            
            RestClientUpdate restUpdate = new RestClientUpdate();
            restUpdate.ObjectUpdate(car);
        }

       
    }
}
