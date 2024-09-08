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
        public enum enGender
        {
            Female = 0,
            Male = 1,
        }
        public enGender Gender { get; set; }
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
            this.Gender = (enGender)0;
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
            this.Gender = (enGender)Gender;
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
            string NationalNumber = "",
                FirstName = "",
                SecondName = "",
                ThirdName = "",
                LastName = "",
                Email = "",
                Phone = "",
                Address = "",
                ImgPath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            byte Gender = 0;

            if (
                clsPeopleDataAccess.GetPersonByID(
                    ID,
                    ref NationalNumber,
                    ref FirstName,
                    ref SecondName,
                    ref ThirdName,
                    ref LastName,
                    ref Gender,
                    ref Email,
                    ref Phone,
                    ref Address,
                    ref DateOfBirth,
                    ref CountryID,
                    ref ImgPath
                )
            )
            {
                return new clsPerson(
                    ID,
                    NationalNumber,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    Gender,
                    Email,
                    Phone,
                    Address,
                    DateOfBirth,
                    CountryID,
                    ImgPath
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
            string FirstName = "",
                SecondName = "",
                ThirdName = "",
                LastName = "",
                Email = "",
                Phone = "",
                Address = "",
                ImgPath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            byte Gender = 0;

            if (
                clsPeopleDataAccess.GetPersonByNationalNo(
                    NationalNo,
                    ref ID,
                    ref FirstName,
                    ref SecondName,
                    ref ThirdName,
                    ref LastName,
                    ref Gender,
                    ref Email,
                    ref Phone,
                    ref Address,
                    ref DateOfBirth,
                    ref CountryID,
                    ref ImgPath
                )
            )
            {
                return new clsPerson(
                    ID,
                    NationalNo,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    Gender,
                    Email,
                    Phone,
                    Address,
                    DateOfBirth,
                    CountryID,
                    ImgPath
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
            (byte)this.Gender,
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
            (byte)this.Gender,
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
