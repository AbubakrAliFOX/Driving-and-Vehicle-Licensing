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
    public partial class AddNewPerson : Form
    {
        clsPerson newPerson;
        public AddNewPerson()
        {
            InitializeComponent();
            pbPersonPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            dtpDateTime.Format = DateTimePickerFormat.Short;
            cbCountries.DataSource = clsCountry.GetAllCountries();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newPerson = new clsPerson();
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

            if (newPerson.Save())
            {
                MessageBox.Show("Person Saved Successfully");
            } else
            {
                MessageBox.Show("Error");

            }
        }

        private void llAddPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
