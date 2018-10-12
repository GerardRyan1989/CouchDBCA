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
    public partial class MapReduce : Form
    {
        public MapReduce()
        {
            InitializeComponent();
            this.Size = new Size(1500, 820);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            RestClientView view = new RestClientView();
            string make = txtMake.Text;
            string model = txtModel.Text;
            List<Car> cars = new List<Car>();
 
            var returnedCars = await view.getView(make,model);

            foreach(Car car in returnedCars){
                cars.Add(car);
            }

            dataGrid.DataSource = cars;
            dataGrid.AutoResizeColumns();
        }   
    }
}
