using BusinessLayer;
using PresentationLayer.Global_Classes;
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
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

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

        private void tbTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestTitle, "Title cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbTestTitle, null);
            };
        }

        private void tbTestFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestFees, "Price cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbTestFees, null);
            };

            if (!clsValidate.IsNumber(tbTestFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestFees, "Price must be a number");
            }
            else
            {
                errorProvider1.SetError(tbTestFees, null);
            };
        }

        private void tbTestDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestDesc.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestDesc, "Description cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbTestDesc, null);
            };
        }
    }
}
