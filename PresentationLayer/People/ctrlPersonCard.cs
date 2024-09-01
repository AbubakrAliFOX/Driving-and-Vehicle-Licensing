using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer.Global_Classes;

namespace PresentationLayer
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();

        }

        private clsPerson _PersonInfo;

        public clsPerson PersonInfo
        {
            get { return _PersonInfo; }
            set
            {
                _PersonInfo = value;
                if (_PersonInfo == null)
                {
                    ResetPersonCard();
                }
                else
                {
                    FillPersonCard(_PersonInfo);
                }
            }
        }

        private void FillPersonCard(clsPerson personInfo)
        {
            if (personInfo.ImagePath != "")
            {
                pbPersonPhoto.Image = Image.FromFile(clsUtils.GetProfileImage(personInfo.ImagePath));
            } else
            {
                pbPersonPhoto.Image = Properties.Resources.user1;
            }

            lblPersonID.Text = personInfo.ID.ToString();
            lblName.Text = $"{personInfo.FirstName} {personInfo.LastName}";
            lblNationalNumber.Text = personInfo.NationalNumber;
            lblGender.Text = personInfo.Gender == 1 ? "Female" : "Male";
            lblEmail.Text = personInfo.Email;
            lblPhone.Text = personInfo.Phone;
            lblAddress.Text = personInfo.Address;
            lblDateOfBirth.Text = personInfo.DateOfBirth.ToString("dd/MM/yyyy");

            lblCountry.Text = clsCountry.Find(personInfo.CountryID);
        }

        private void ResetPersonCard()
        {
            pbPersonPhoto.Image = Properties.Resources.user1;

            lblPersonID.Text = "";
            lblName.Text = "";
            lblNationalNumber.Text = "";
            lblGender.Text = "";
            lblEmail.Text = "";
            lblPhone.Text = "";
            lblAddress.Text = "";
            lblDateOfBirth.Text = "";

            lblCountry.Text = "";
        }

    }
}
