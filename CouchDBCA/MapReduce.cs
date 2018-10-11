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
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            RestClientView view = new RestClientView();
            string make = txtMake.Text;
            string model = txtModel.Text;
            await view.getView(make,model);
        }   
    }
}
