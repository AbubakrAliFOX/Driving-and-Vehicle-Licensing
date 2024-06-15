using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsPerson
    {
        public int ID { set; get; }
        public string nationalNumber { set; get; }
        public string firstName { set; get; }
        public string secondName { set; get; }
        public string thirdName { set; get; }
        public string lastName { set; get; }
        public int gender { set; get; }
        public string email { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        public DateTime dateOfBirth { set; get; }
        public string imgPath { set; get; }
        public int countryID { set; get; }

        public clsPerson(
            int ID,
            string NationalNumber,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            int Gender,
            string Email,
            string Phone,
            string Address,
            DateTime DateOfBirth,
            int CountryID,
            string ImagePath
        )
        {
            this.ID = ID;
            this.nationalNumber = NationalNumber;
            this.firstName = FirstName;
            this.secondName = SecondName;
            this.thirdName = ThirdName;
            this.lastName = LastName;
            this.gender = Gender;
            this.email = Email;
            this.phone = Phone;
            this.address = Address;
            this.dateOfBirth = DateOfBirth;
            this.countryID = CountryID;
            this.imgPath = ImagePath;
        }

        public static clsPerson find(int ID)
        {
            string nationalNumber = "",
                firstName = "",
                secondName = "",
                thirdName = "",
                lastName = "",
                email = "",
                phone = "",
                address = "",
                imgPath = "";
            DateTime dateOfBirth = DateTime.Now;
            int countryID = -1;
            byte gender = 0;

            if (
                clsPeopleDataAccess.GetPersonByID(
                    ID,
                    ref nationalNumber,
                    ref firstName,
                    ref secondName,
                    ref thirdName,
                    ref lastName,
                    ref gender,
                    ref email,
                    ref phone,
                    ref address,
                    ref dateOfBirth,
                    ref countryID,
                    ref imgPath
                )
            )
            {
                return new clsPerson(
                    ID,
                    nationalNumber,
                    firstName,
                    secondName,
                    thirdName,
                    lastName,
                    gender,
                    email,
                    phone,
                    address,
                    dateOfBirth,
                    countryID,
                    imgPath
                );
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }
    }
}
