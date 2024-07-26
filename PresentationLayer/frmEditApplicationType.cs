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
    public partial class frmEditApplicationType : Form
    {
        public frmEditApplicationType(int ID, string Title, decimal Fees)
        {
            InitializeComponent();

            lblApplicationID.Text = ID.ToString();

            tbApplicationTitle.Text = Title;

            tbApplicationFees.Text = Fees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsApplication.UpdateApplicationType(int.Parse(lblApplicationID.Text), tbApplicationTitle.Text, decimal.Parse(tbApplicationFees.Text)))
            {
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Failed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
