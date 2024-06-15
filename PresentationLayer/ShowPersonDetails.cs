using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ShowPersonDetails : Form
    {
        ctrlPersonCard ctrlPerson;
        clsPerson newPerson;
        public ShowPersonDetails(int personID)
        {
            InitializeComponent();
            SetFormPosition();
            newPerson = clsPerson.find(personID);
            InitializeControls();
            AddControls();
        }

        private void SetFormPosition()
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeControls()
        {
            ctrlPerson = new ctrlPersonCard(newPerson);
        }

        private void AddControls()
        {
            this.Controls.Add(ctrlPerson);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
