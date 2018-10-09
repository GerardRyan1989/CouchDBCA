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

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            RestClientGet restGet = new RestClientGet();

            //returnedCar = await restGet.GetObject(txtReg.Text);


            //txtRegistration.Text = returnedCar._id.ToString();
            //txtMake.Text = returnedCar.Make;
            //txtModel.Text = returnedCar.Model;
            //txtEngineSize.Text = returnedCar.EngineSize.ToString();
            //cboExtras.Text = returnedCar.Extras.ToString();
            //txtFuelType.Text = returnedCar.FuelType;
            //txtMileage.Text = returnedCar.mileage.ToString();
            //txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
            //txtPreviousOwnerAddress.Text = returnedCar.PrevOwner.Address;
            //txtPreviousOwnerName.Text = returnedCar.PrevOwner.Name;
            //txtNumOfOwners.Text = returnedCar.numofOwners.ToString();
            //txtYearsOwned.Text = returnedCar.PrevOwner.YearsOwned.ToString();
            //txtTransmission.Text = returnedCar.Transmission;
            //txtSafetyRating.Text = returnedCar.SafetyRating.ToString();




            RestClientView view = new RestClientView();

            await view.getView();
           
        }
    }
}
