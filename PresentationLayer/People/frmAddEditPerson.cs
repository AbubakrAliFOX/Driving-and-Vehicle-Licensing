using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using PresentationLayer.Global_Classes;


namespace PresentationLayer
{
    public partial class frmAddEditPerson : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _CurrentMode;

        clsPerson PersonDetails;
        int _PersonID = -1;

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        public frmAddEditPerson()
        {
            InitializeComponent();

            _CurrentMode = enMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _CurrentMode = enMode.Update;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillCountriesList ()
        {
            cbCountries.DataSource = clsCountry.GetAllCountries();
        }

        private void FillData ()
        {
            FillCountriesList();

            dtpDateTime.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateTime.MinDate = DateTime.Now.AddYears(-100);

            if (_CurrentMode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                PersonDetails = new clsPerson();
                dtpDateTime.Value = dtpDateTime.MaxDate;
            } else
            {
                lblTitle.Text = "Update Person";
                PersonDetails = clsPerson.Find(_PersonID);

                if (PersonDetails == null)
                {
                    MessageBox.Show("This form will be closed because no person has been found");
                    this.Close();
                    return;
                }

                lblPersonID.Text = _PersonID.ToString();
                tbNationalNumber.Text = PersonDetails.NationalNumber;
                tbFirstName.Text = PersonDetails.FirstName;
                tbSecondName.Text = PersonDetails.SecondName;
                tbThirdName.Text = PersonDetails.ThirdName;
                tbLastName.Text = PersonDetails.LastName;

                if (PersonDetails.Gender == 0)
                {
                    rbMale.Checked = true;
                }
                else if (PersonDetails.Gender == 1)
                {
                    rbFemale.Checked = true;
                }

                dtpDateTime.Value = PersonDetails.DateOfBirth;
                tbEmail.Text = PersonDetails.Email;
                tbAddress.Text = PersonDetails.Address;
                tbPhone.Text = PersonDetails.Phone;
                cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(PersonDetails.CountryID));

                if (PersonDetails.ImagePath != "")
                {
                    pbPersonPhoto.Load(PersonDetails.ImagePath);
                }

                //LLRemoveImg.Visible = (newPerson.imgPath != "");
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            PersonDetails.NationalNumber = tbNationalNumber.Text;
            PersonDetails.FirstName = tbFirstName.Text;
            PersonDetails.SecondName = tbSecondName.Text;
            PersonDetails.ThirdName = tbThirdName.Text;
            PersonDetails.LastName = tbLastName.Text;

            PersonDetails.Gender = rbMale.Checked ? (byte)0 : (byte)1;
            PersonDetails.DateOfBirth = dtpDateTime.Value;
            PersonDetails.Email = tbEmail.Text;
            PersonDetails.Address = tbAddress.Text;
            PersonDetails.Phone = tbPhone.Text;
            PersonDetails.CountryID = clsCountry.GetCountryID(cbCountries.SelectedValue.ToString());

            if (pbPersonPhoto.ImageLocation != null)
            {
                PersonDetails.ImagePath = pbPersonPhoto.ImageLocation.ToString();
            }
            else
            {
                PersonDetails.ImagePath = "";
            }

            if (PersonDetails.Save())
            {
                MessageBox.Show("Person Saved Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _CurrentMode = enMode.Update;
                _PersonID = PersonDetails.ID;
                FillData();
            } else
            {
                MessageBox.Show("Error");

            }

        }

        private void llAddPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            DialogResult result = openFileDialog.ShowDialog();

            // Process the result if OK was clicked
            if (result == DialogResult.OK)
            {
                // Get the file path selected by the user
                string filePath = openFileDialog.FileName;

                pbPersonPhoto.Load(filePath);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, PersonDetails.ID);
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            System.Windows.Forms.TextBox Temp = ((System.Windows.Forms.TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (tbEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidate.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            };
        }

        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbNationalNumber, null);
            }

            //Make sure the national number is not used by another person
            if (tbNationalNumber.Text.Trim() != PersonDetails.NationalNumber && clsPerson.PersonExists(tbNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(tbNationalNumber, null);
            }
        }
    }
}
