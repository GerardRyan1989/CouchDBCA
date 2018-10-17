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
    public partial class RemoveCar : Form
    {
        Car returnedCar = new Car();

        public RemoveCar()
        {
            InitializeComponent();
            this.Size = new Size(1000, 820);
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            RestClientDelete restDelete = new RestClientDelete();     
            restDelete.DeleteObject(returnedCar._id, returnedCar._rev);
            MessageBox.Show("Car Removed Successfully!");

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

        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            string reg = txtReg.Text.ToUpper();
            RestClientGet restGet = new RestClientGet();
            returnedCar = await restGet.GetObject(reg);
            List<ServiceHistory> services = new List<ServiceHistory>();
            string returnedextras = "";

            if (returnedCar != null)
            {

                txtRegistration.Text = returnedCar._id;
                txtMake.Text = returnedCar.Make;
                txtModel.Text = returnedCar.Model;
                txtEngineSize.Text = returnedCar.EngineSize.ToString();
                txtFuelType.Text = returnedCar.FuelType;
                txtMileage.Text = returnedCar.mileage.ToString();
                txtSalesPrice.Text = returnedCar.SalesPrices.ToString();
                txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
                txtPreviousOwnerAddress.Text = returnedCar.PrevOwner.Address;
                txtPreviousOwnerName.Text = returnedCar.PrevOwner.Name;
                txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
                txtYearsOwned.Text = returnedCar.PrevOwner.YearsOwned.ToString();
                txtTransmission.Text = returnedCar.Transmission;
                txtSafetyRating.Text = returnedCar.SafetyRating.ToString();

                foreach (string extra in returnedCar.Extras)
                {
                    returnedextras += extra + ", ";
                }

                if (returnedCar.ServHistory != null)
                {
                    foreach (ServiceHistory serv in returnedCar.ServHistory)
                    {
                        services.Add(serv);
                    }
                }

                cboExtras.Text = returnedextras;
                dataGridService.DataSource = services;
            }
            else
            {
                MessageBox.Show("No Matching Cars Found !");
            }
        }
    }
}
