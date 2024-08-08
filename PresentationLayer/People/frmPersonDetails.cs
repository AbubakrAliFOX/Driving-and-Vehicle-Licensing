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
    public partial class frmPersonDetails : Form
    {
        ctrlPersonCard ctrlPerson;
        clsPerson newPerson;
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            SetFormPosition();
            newPerson = clsPerson.Find(personID);
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
            ctrlPerson = new ctrlPersonCard();
            ctrlPerson.PersonInfo = newPerson;
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
