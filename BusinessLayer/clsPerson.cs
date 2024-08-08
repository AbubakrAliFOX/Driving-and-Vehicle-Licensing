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
        public enum enMode { AddNew = 0, Update};
        private enMode _Mode;
        public int ID { set; get; }
        public string NationalNumber { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public byte Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string ImagePath { set; get; }
        public int CountryID { set; get; }

        public clsPerson()
        {
            this.ID = -1;
            this.NationalNumber = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gender = 0;
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";
            _Mode = enMode.AddNew;
        }
        public clsPerson(
            int ID,
            string NationalNumber,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            byte Gender,
            string Email,
            string Phone,
            string Address,
            DateTime DateOfBirth,
            int CountryID,
            string ImagePath
        )
        {
            this.ID = ID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }

        public static clsPerson Find(int ID)
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

        public static clsPerson Find(string NationalNo)
        {
            int ID = -1;
            string firstName = "",
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
                clsPeopleDataAccess.GetPersonByNationalNo(
                    NationalNo,
                    ref ID,
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
                    NationalNo,
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

        private bool _AddNewPerson()
        {
            this.ID = clsPeopleDataAccess.AddNewPerson(this.NationalNumber,this.FirstName, this.SecondName, 
            this.ThirdName, this.LastName,
            this.Gender,
            this.Email,
            this.Phone,
            this.Address,
            this.DateOfBirth,
            this.CountryID,
            this.ImagePath);
            return (this.ID != -1);
        }

        private bool _UpdatePerson ()
        {
            return clsPeopleDataAccess.UpdatePerson(this.ID, this.NationalNumber,
            this.FirstName, this.SecondName,
            this.ThirdName, this.LastName,
            this.Gender,
            this.Email,
            this.Phone,
            this.Address,
            this.DateOfBirth,
            this.CountryID,
            this.ImagePath);
        }

        public static bool Delete (int ID)
        {
            return clsPeopleDataAccess.Delete(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();

            }
            return false; 
        }
    
        public static bool PersonExists(string NationalNo)
        {
            return clsPeopleDataAccess.PersonExists(NationalNo);
        }
    }
}
