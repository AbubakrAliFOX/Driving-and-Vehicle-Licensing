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

namespace PresentationLayer
{
    public partial class AddNewPerson : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _CurrentMode;

        clsPerson newPerson;
        int _PersonID;
        public AddNewPerson(int PersonID)
        {
            InitializeComponent();

            SetCurrentMode(PersonID);
            AdjustControls();
            FillData();

        }

        private void SetCurrentMode (int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                _CurrentMode = enMode.AddNew;
            }
            else
            {
                _CurrentMode = enMode.Update;
            }
        }

        private void FillCountriesList ()
        {
            cbCountries.DataSource = clsCountry.GetAllCountries();
        }

        private void AdjustControls ()
        {
            pbPersonPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            dtpDateTime.Format = DateTimePickerFormat.Short;
        }

        private void FillData ()
        {
            FillCountriesList();

            if (_CurrentMode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                newPerson = new clsPerson();
            } else
            {
                lblTitle.Text = "Update Person";
                newPerson = clsPerson.Find(_PersonID);

                if (newPerson == null)
                {
                    MessageBox.Show("This form will be closed because no person has been found");
                    this.Close();
                    return;
                }

                lblPersonID.Text = _PersonID.ToString();
                tbNationalNumber.Text = newPerson.nationalNumber;
                tbFirstName.Text = newPerson.firstName;
                tbSecondName.Text = newPerson.secondName;
                tbThirdName.Text = newPerson.thirdName;
                tbLastName.Text = newPerson.lastName;

                if (newPerson.gender == 0)
                {
                    rbMale.Checked = true;
                }
                else if (newPerson.gender == 1)
                {
                    rbFemale.Checked = true;
                }

                dtpDateTime.Value = newPerson.dateOfBirth;
                tbEmail.Text = newPerson.email;
                tbAddress.Text = newPerson.address;
                tbPhone.Text = newPerson.phone;
                cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(newPerson.countryID));

                if (newPerson.imgPath != "")
                {
                    pbPersonPhoto.Load(newPerson.imgPath);
                }

                //LLRemoveImg.Visible = (newPerson.imgPath != "");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            newPerson.nationalNumber = tbNationalNumber.Text;
            newPerson.firstName = tbFirstName.Text;
            newPerson.secondName = tbSecondName.Text;
            newPerson.thirdName = tbThirdName.Text;
            newPerson.lastName = tbLastName.Text;

            newPerson.gender = rbMale.Checked ? (byte)0 : (byte)1;
            newPerson.dateOfBirth = dtpDateTime.Value;
            newPerson.email = tbEmail.Text;
            newPerson.address = tbAddress.Text;
            newPerson.phone = tbPhone.Text;
            newPerson.countryID = clsCountry.GetCountryID(cbCountries.SelectedValue.ToString());

            if (pbPersonPhoto.ImageLocation != null)
            {
                newPerson.imgPath = pbPersonPhoto.ImageLocation.ToString();
            }
            else
            {
                newPerson.imgPath = "";
            }

            if (newPerson.Save())
            {
                MessageBox.Show("Person Saved Successfully");
                _CurrentMode = enMode.Update;
                _PersonID = newPerson.ID;
                FillData();
            } else
            {
                MessageBox.Show("Error");

            }

        }

        private void llAddPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
