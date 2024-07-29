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
                    MessageBox.Show("Person Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FillPersonCard(_PersonInfo);
                }
            }
        }

        private void FillPersonCard(clsPerson personInfo)
        {
            if (personInfo.imgPath != "")
            {
                pbPersonPhoto.Image = Image.FromFile(personInfo.imgPath);
            } else
            {
                pbPersonPhoto.Image = Image.FromFile("E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\user1.png");
            }

            lblPersonID.Text = personInfo.ID.ToString();
            lblName.Text = $"{personInfo.firstName} {personInfo.lastName}";
            lblNationalNumber.Text = personInfo.nationalNumber;
            lblGender.Text = personInfo.gender == 1 ? "Female" : "Male";
            lblEmail.Text = personInfo.email;
            lblPhone.Text = personInfo.phone;
            lblAddress.Text = personInfo.address;
            lblDateOfBirth.Text = personInfo.dateOfBirth.ToString("dd/MM/yyyy");

            lblCountry.Text = clsCountry.Find(personInfo.countryID);
        }

        private void ResetPersonCard()
        {
            pbPersonPhoto.Image = Image.FromFile("E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\user1.png");

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
