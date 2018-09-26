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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            //RestClient restClient = new RestClient();
            //restClient.endPoint = txtURL.Text;
            //debugOutput("rest Client Created");

            //string strResponse = string.Empty;

            //strResponse = restClient.makeRequest();

            //debugOutput(strResponse);
            //RestClientPost rest = new RestClientPost();

            //rest.postObject();


            RestClientGet restGet = new RestClientGet();

            await restGet.GetObject();

            //RestClientDelete restDelete = new RestClientDelete();

            //restDelete.DeleteObject();
        }

        public void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.Text.Length;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
