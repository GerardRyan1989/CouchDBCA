using DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CouchDBCA
{
    public partial class UpdateCar : Form
    {

        Car returnedCar;
        List<ServiceHistory> services;

        public UpdateCar()
        {
            InitializeComponent();
            this.Size = new Size(900, 850);
            cboExtras.Items.Add("Air Con, Leather Seats");
            cboExtras.Items.Add("Air Con, Alloy Wheels");
            cboExtras.Items.Add("Air Con, Alloy Wheels, Leather Seats");
            cboExtras.Items.Add("Alloy Wheels");
            cboExtras.Items.Add("Leather Seats");
            cboExtras.Items.Add("Air Con");
        }

        //Searching for a car 
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string reg = txtReg.Text.ToUpper();
           
            RestClientGet restGet = new RestClientGet();
            returnedCar = await restGet.GetObject(reg);
            services = new List<ServiceHistory>();
            string returnedextras = "" ;

            if (returnedCar != null){

                txtRegistration.Text = returnedCar._id.ToString();
                txtMake.Text = returnedCar.Make;
                txtModel.Text = returnedCar.Model;
                txtEngineSize.Text = returnedCar.EngineSize.ToString(); 
                txtFuelType.Text = returnedCar.FuelType;
                txtMileage.Text = returnedCar.mileage.ToString();
                txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
                txtPreviousOwnerAddress.Text = returnedCar.PrevOwner.Address;
                txtPreviousOwnerName.Text = returnedCar.PrevOwner.Name;
                txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
                txtYearsOwned.Text = returnedCar.PrevOwner.YearsOwned.ToString();
                txtTransmission.Text = returnedCar.Transmission;
                txtSafetyRating.Text = returnedCar.SafetyRating.ToString();
                txtSalesPrice.Text = returnedCar.SalesPrices.ToString();
                

                foreach(string extra in returnedCar.Extras)
                {
                    returnedextras += extra + ", ";
                }

                if(returnedCar.ServHistory != null)
                {
                    foreach (ServiceHistory serv in returnedCar.ServHistory)
                    {
                        services.Add(serv);
                    }
                }

                cboExtras.Text = returnedextras;
                
                if (cboExtras.Text != "")
                {
                    switch (cboExtras.Text)
                    {
                        case "Air Con, Leather Seats, ":
                            cboExtras.SelectedIndex = 0;
                            break;
                        case "Air Con, Alloy Wheels, ":
                            cboExtras.SelectedIndex = 1;
                            break;
                        case "Air Con, Alloy Wheels, Leather Seats, ":
                            cboExtras.SelectedIndex = 2;
                            break;
                        case "Alloy Wheels, ":
                            cboExtras.SelectedIndex = 3;
                            break;
                        case "Leather Seats, ":
                            cboExtras.SelectedIndex = 4;
                            break;
                        case "Air Con, ":
                            cboExtras.SelectedIndex = 5;
                            break;
                        default:
                            cboExtras.SelectedIndex = -1;
                            break;
                            
                    }

                }            
                dataGridService.DataSource = services;
            }
            else
            {
                MessageBox.Show("No matching car could be found!");
            }            
        }


        //Updating The Car
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            List<string> extrasTempList = new List<string>();
            Car car;

            if (cboExtras.Text != "")
            {
                switch (cboExtras.SelectedItem.ToString())
                {
                    case "Air Con, Leather Seats":
                        extrasTempList.Add("Air Con");
                        extrasTempList.Add("Leather Seats");
                        break;
                    case "Air Con, Alloy Wheels":
                        extrasTempList.Add("Air Con");
                        extrasTempList.Add("Alloy Wheels");
                        break;
                    case "Air Con, Alloy Wheels, Leather Seats":
                        extrasTempList.Add("Air Con");
                        extrasTempList.Add("Alloy Wheels");
                        extrasTempList.Add("Leather Seats");
                        break;
                    case "Air Con":
                        extrasTempList.Add("Air Con");
                        break;
                    case "Alloy Wheels":
                        extrasTempList.Add("Alloy Wheels");
                        break;
                    case "Leather Seats":
                        extrasTempList.Add("Leather Seats");
                        break;
                }

                try
                {
                    car = new Car
                    {
                        _id = txtRegistration.Text.ToUpper(),
                        _rev = returnedCar._rev,
                        Make = txtMake.Text.ToUpper(),
                        Model = txtModel.Text.ToUpper(),
                        EngineSize = Convert.ToDouble(txtEngineSize.Text),
                        FuelType = txtFuelType.Text.ToUpper(),
                        Extras = extrasTempList,
                        Transmission = txtTransmission.Text.ToUpper(),
                        ServHistory = services,
                        SafetyRating = Convert.ToInt32(txtSafetyRating.Text),
                        numofOwners = Convert.ToInt32(txtNumOfOwners.Text),
                        SalesPrices = Convert.ToInt32(txtSalesPrice.Text),
                        mileage = Convert.ToInt32(txtMileage.Text),

                        PrevOwner = new PreviousOwners
                        {
                            Name = txtPreviousOwnerName.Text.ToUpper(),
                            Address = txtPreviousOwnerAddress.Text.ToUpper(),
                            YearsOwned = Convert.ToInt16(txtYearsOwned.Text)
                        }
                    };

                    RestClientUpdate restUpdate = new RestClientUpdate();
                    restUpdate.ObjectUpdate(car);
                    MessageBox.Show("Car Updated Successfully");

                    txtReg.Text = "";
                    cboExtras.Text = "";
                    txtRegistration.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    txtEngineSize.Text = "";
                    txtFuelType.Text = "";
                    txtMileage.Text = "";
                    txtNumOfOwners.Text = "";
                    txtPreviousOwnerAddress.Text = "";
                    txtPreviousOwnerName.Text = "";
                    txtNumOfOwners.Text = "";
                    txtYearsOwned.Text = "";
                    txtTransmission.Text = "";
                    txtSafetyRating.Text = "";
                    txtSalesPrice.Text = "";
                    
                    dataGridService.DataSource = null;
                    dataGridService.Refresh();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check all fields are filled in correctly");
                }
            }
            else
            {
                MessageBox.Show("please enter a value for extras");
            }
        }
    
        private void btnAddService_Click(object sender, EventArgs e)
        {
            var service = new ServiceHistory(txtGarage.Text, txtServicedMile.Text, Convert.ToDateTime(dtpServiceDate.Value));     
            services.Add(service);
        }
    }
}
