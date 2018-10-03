using System;
using System.Drawing;
using System.Windows.Forms;

namespace CouchDBCA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Size = new Size(700, 600);
        }

        private void updateCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCar updateCar = new UpdateCar();

            updateCar.Visible = true;
        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCar removeCar = new RemoveCar();

            removeCar.Visible = true;
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();

            addCar.Visible = true;
        }
    }
}
