using PeopleBussinessLayer;
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
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard(clsPerson personInfo)
        {
            InitializeComponent();

            this.pbPersonPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (personInfo == null)
            {
                MessageBox.Show("Something went wrong!", "Error");
                Close();
            } else
            {
                FillPersonCard(personInfo);
            }


        }

        private void FillPersonCard(clsPerson personInfo)
        {
            pbPersonPhoto.Image = Image.FromFile(
                    personInfo.imgPath != "" ?
                        personInfo.imgPath :
                        "E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\user1.png"
                    );

            lblPersonID.Text = personInfo.ID.ToString();
            lblName.Text = $"{personInfo.firstName} {personInfo.lastName}";
            lblNationalNumber.Text = personInfo.nationalNumber;
            lblGender.Text = personInfo.gender == 1 ? "Female" : "Male";
            lblEmail.Text = personInfo.email;
            lblPhone.Text = personInfo.phone;
            lblAddress.Text = personInfo.address;
            lblDateOfBirth.Text = personInfo.dateOfBirth.ToString("dd/MM/yyyy");
        }

        public void Close ()
        {
            this.Close();
        }
    }
}
