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
    public partial class frmEditTestType : Form
    {
        public frmEditTestType(int ID, string Title, string Description, decimal Fees)
        {
            InitializeComponent();

            lblTestID.Text = ID.ToString();

            tbTestTitle.Text = Title;

            tbTestDesc.Text = Description;

            tbTestFees.Text = Fees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsTest.UpdateTestType(int.Parse(lblTestID.Text), tbTestTitle.Text, tbTestDesc.Text, decimal.Parse(tbTestFees.Text)))
            {
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
