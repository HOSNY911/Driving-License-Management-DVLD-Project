using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD___Database_Layer;

namespace DVLD___Business_Layer
{
    public class clsPersonBSL
    {
        public enum enMode {AddNew=0,Update=1};
        private  enMode Mode;

        public int ID {  get; private set; }
        
        public string NationalNo { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public byte Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public clsPersonBSL()
        {
            this.ID = -1;

            this.NationalNo = string.Empty;

            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;

            this.Gendor = 0;
            this.Address = string.Empty;
            this.DateOfBirth = DateTime.MinValue;
            this.NationalityCountryID = -1;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsPersonBSL(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            byte Gender, string Address, DateTime DateOfBirth, string Phone, string Email,int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;

            this.NationalNo = NationalNo;

            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;

            this.Gendor = Gender;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }


        public static clsPersonBSL FindPersonByID(int ID)
        {
            string NationalNo = string.Empty, FirstName = string.Empty, SecondName = string.Empty, ThirdName = string.Empty, LastName = string.Empty, Phone = string.Empty, Address = string.Empty, Email = string.Empty, ImagePath = string.Empty;

            byte Gender = 0;

            DateTime DateOfBirth = DateTime.MinValue;

            int NationalityCountryID = 0;

            if(clsPersonDBL.FindPersonByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPersonBSL(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gender, Address, DateOfBirth, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }


        public static clsPersonBSL FindPersonByNationalNo(string NationalNo)
        {
            int ID = -1;

            string FirstName = string.Empty, SecondName = string.Empty, ThirdName = string.Empty, LastName = string.Empty, Phone = string.Empty, Address = string.Empty, Email = string.Empty, ImagePath = string.Empty;

            byte Gender = 0;

            DateTime DateOfBirth = DateTime.MinValue;

            int NationalityCountryID = 0;

            if (clsPersonDBL.FindPersonByNationalNo(ref ID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPersonBSL(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gender, Address, DateOfBirth, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }


        public static string FindCountryByID(int CountryID)
        {
            return clsPersonDBL.FindCountryByID(CountryID);
        }


        public static DataTable GetAllPeople()
        {
            return clsPersonDBL.GetAllPeople();
        }


        private bool _AddNewPerson()
        {
            this.ID = clsPersonDBL.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address
                , this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            if (this.ID == -1)
                return false;

            return true;
        }


        private bool _UpdatePerson()
        {
            if(clsPersonDBL.UpdatePerson(this.ID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address
                , this.Phone, this.Email, this.NationalityCountryID, this.ImagePath))
                return true;
            else
                return false;
        }

        public static bool DeletePerson(int PersonID)
        {
           return clsPersonDBL.DeletePerson(PersonID);
        }


        public static bool IsPersonExistsByID(int personID)
        {
            return clsPersonDBL.IsPersonExistsByID(personID);
        }

        public static bool IsPersonExistsByNationalNo(string NationalNo)
        {
            return clsPersonDBL.IsPersonExistsByNationalNo(NationalNo);
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                       

                    case enMode.Update:
                    return (_UpdatePerson());
                
            }
            return false;
        }
    }
}
