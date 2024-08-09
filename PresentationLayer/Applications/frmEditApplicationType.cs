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
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (clsApplication.UpdateApplicationType(int.Parse(lblApplicationID.Text), tbApplicationTitle.Text, decimal.Parse(tbApplicationFees.Text)))
            {
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Failed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbApplicationTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTitle, "Title cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbApplicationTitle, null);
            };
        }

        private void tbApplicationFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationFees, "Price cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbApplicationFees, null);
            };

            if (!clsValidate.IsNumber(tbApplicationFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationFees, "Price must be a number");
            }
            else
            {
                errorProvider1.SetError(tbApplicationFees, null);
            };
        }
    }
}
