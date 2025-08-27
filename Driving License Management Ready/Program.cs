using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD___Business_Layer;

namespace Driving_License_Management_Ready
{
    internal class Program
    {

        public static void GetAllPeople()
        {
            DataTable People = clsPersonBSL.GetAllPeople();

            foreach(DataRow dataRow in People.Rows)
            {
                Console.WriteLine(dataRow["PersonID"]);
                Console.WriteLine(dataRow["NationalNo"]);
                Console.WriteLine(dataRow["FirstName"]);
                Console.WriteLine(dataRow["SecondName"]);
                Console.WriteLine(dataRow["ThirdName"]);
                Console.WriteLine(dataRow["LastName"]);
                Console.WriteLine(dataRow["Gendor"]);
                Console.WriteLine(dataRow["Address"]);
                Console.WriteLine(dataRow["DateOfBirth"]);
                Console.WriteLine(dataRow["CountryName"]);
                Console.WriteLine(dataRow["Phone"]);
                Console.WriteLine($"{dataRow["Email"]} \n\n");
               

            }
        }

        public static void AddNewPerson()
        {
            clsPersonBSL personBSL = new clsPersonBSL();

            personBSL.NationalNo = "N77";
            personBSL.FirstName = "Hosny";
            personBSL.SecondName = "Ayman";
            personBSL.ThirdName = "Hosny";
            personBSL.LastName = "Adly";
            personBSL.DateOfBirth = new DateTime(2001, 2, 25);
            personBSL.Gendor = 0;
            personBSL.Address = "Giza Shara Elmonib";
            personBSL.Phone = "01097476025";
            personBSL.Email = "hosny@gmail.com";
            personBSL.NationalityCountryID = 51;
            personBSL.ImagePath = string.Empty;

            if (personBSL.Save())
                Console.WriteLine($"Person Add Succfuly and the id is {personBSL.ID}");
            else
                Console.WriteLine("Person Add failed");

        }

        public static void FindPersonByID(int ID)
        {
            clsPersonBSL Person = clsPersonBSL.FindPersonByID(ID);
            if (Person != null)
            {
                Console.WriteLine(Person.ID);
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gendor);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(clsPersonBSL.FindCountryByID(Person.NationalityCountryID));
                Console.WriteLine(Person.ImagePath);
            }
            else
                Console.WriteLine("Person not found");
        }

        public static void FindPersonByNationalNo(string NationalNo)
        {
            clsPersonBSL Person = clsPersonBSL.FindPersonByNationalNo(NationalNo);
            if (Person != null)
            {
                Console.WriteLine(Person.ID);
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gendor);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(clsPersonBSL.FindCountryByID(Person.NationalityCountryID));
                Console.WriteLine(Person.ImagePath);
            }
            else
                Console.WriteLine("Person not found");
        }

        public static void UpdatePerson(int ID)
        {
            clsPersonBSL Person = clsPersonBSL.FindPersonByID(ID);
            if (Person != null)
            {
                Person.NationalNo = "GG14";
                Person.FirstName = "Nader";
                Person.SecondName = "Elside";
                Person.ThirdName = "Mohammed";
                Person.LastName = "Ismail";
                Person.DateOfBirth = DateTime.Now;
                Person.Gendor = 0;
                Person.Address = "ss dd ff";
                Person.Email = "Nader@Elside.com";
                Person.Phone = "01999992";
                Person.NationalityCountryID = 51;
                Person.ImagePath = string.Empty;

                if(Person.Save())
                {
                    Console.WriteLine("Person Update successfuly");
                }
                else
                    Console.WriteLine("Person Update Failed");
            }
            else
                Console.WriteLine("Person Not Found");
        }

        public static void DeletePerson(int PersonID)
        {
            if(clsPersonBSL.DeletePerson(PersonID))
                Console.WriteLine("person delete successfuly");
            else
                Console.WriteLine("person delete failed");
        }

        public static void IsPersonExistsByID(int PersonID)
        {
            if (clsPersonBSL.IsPersonExistsByID(PersonID))
                Console.WriteLine("person is here ");
            else
                Console.WriteLine("person is NOT here");
        }

        public static void IsPersonExistsByNationalNo(string NationalNo)
        {
            if (clsPersonBSL.IsPersonExistsByNationalNo(NationalNo))
                Console.WriteLine("person is here ");
            else
                Console.WriteLine("person is NOT here");
        }

        static void Main(string[] args)
        {
            //GetAllPeople();
            //AddNewPerson();
            //FindPersonByID(1030);
            //FindPersonByNationalNo("N55");
            //UpdatePerson(1032);
            //DeletePerson(1032);
            //IsPersonExistsByID(1030);
            //IsPersonExistsByNationalNo("N1ss");
        }
    }
}
