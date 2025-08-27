using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___Database_Layer
{
    public static class clsPersonDBL
    {

        public static bool FindPersonByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFind = false;
            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select * from People where People.PersonID=@ID;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFind = true;

                                NationalNo = (string)Reader["NationalNo"];
                                FirstName = (string)Reader["FirstName"];
                                SecondName = (string)Reader["SecondName"];
                                ThirdName = (string)Reader["ThirdName"];
                                LastName = (string)Reader["LastName"];
                                DateOfBirth = (DateTime)Reader["DateOfBirth"];
                                Gendor = (byte)Reader["Gendor"];
                                Address = (string)Reader["Address"];
                                Phone = (string)Reader["Phone"];
                                Email = (string)Reader["Email"];
                                NationalityCountryID = (int)Reader["NationalityCountryID"];
                                ImagePath = Reader["ImagePath"] == DBNull.Value ? null : (string)Reader["ImagePath"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                    
                }
            }
            return IsFind;
        }


        public static bool FindPersonByNationalNo(ref int ID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFind = false;

            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select * from People where People.NationalNo=@NationalNo;";

                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFind = true;

                                ID = (int)Reader["PersonID"];
                                FirstName = (string)Reader["FirstName"];
                                SecondName = (string)Reader["SecondName"];
                                ThirdName = (string)Reader["ThirdName"];
                                LastName = (string)Reader["LastName"];
                                DateOfBirth = (DateTime)Reader["DateOfBirth"];
                                Gendor = (byte)Reader["Gendor"];
                                Address = (string)Reader["Address"];
                                Phone = (string)Reader["Phone"];
                                Email = (string)Reader["Email"];
                                NationalityCountryID = (int)Reader["NationalityCountryID"];
                                ImagePath = Reader["ImagePath"] == DBNull.Value ? null : (string)Reader["ImagePath"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }

                }
            }
            return IsFind;
        }


        public static string FindCountryByID(int CountryID)
        {
            string CountryName = string.Empty;

            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select Countries.CountryName from Countries where Countries.CountryID =@CountryID;";
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        Connection.Open();
                        object Country = command.ExecuteScalar();

                        if (Country != null)
                        {
                            CountryName = (string)Country;
                        }
                    }

                    catch(Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                    
                    
                }

            }

            return CountryName;
        }

        public static DataTable GetAllPeople()
        {
            DataTable AllPeople = new DataTable();

            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select * from People_View;";

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        Connection.Open();

                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                AllPeople.Load(Reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                }

                   
            }

            return AllPeople;
        }


        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email,int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                

                string query = @"insert into People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
                                 values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);;
                                 select SCOPE_IDENTITY()";
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;
                    Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = FirstName;
                    Command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = SecondName;
                    Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = ThirdName;
                    Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = LastName;
                    Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
                    Command.Parameters.Add("@Gendor", SqlDbType.TinyInt).Value = Gendor;
                    Command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
                    Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;
                    Command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email;
                    Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;

                    if(string.IsNullOrEmpty(ImagePath))
                    {
                        Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = DBNull.Value;
                    }
                    else
                    {
                        Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = ImagePath;
                    }
                       

                    try
                    {
                        Connection.Open();

                        object personid = Command.ExecuteScalar();

                        if (personid != null && int.TryParse(personid.ToString(), out int Result))
                        {
                            PersonID = Result;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                }


                    

            }

            return PersonID;
        }

       public static bool UpdatePerson(int ID,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int NumberOfRowEffected = 0;

            using (SqlConnection Connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = @"update People set NationalNo=@NationalNo,FirstName=@FirstName,SecondName=@SecondName,ThirdName=@ThirdName,LastName=@LastName
                               ,DateOfBirth=@DateOfBirth,Gendor=@Gendor,Address=@Address,Phone=@Phone,Email=@Email,NationalityCountryID=@NationalityCountryID,ImagePath=@ImagePath
                                where People.PersonID=@ID;";

                using(SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;
                    Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = FirstName;
                    Command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = SecondName;
                    Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = ThirdName;
                    Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = LastName;
                    Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
                    Command.Parameters.Add("@Gendor", SqlDbType.TinyInt).Value = Gendor;
                    Command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
                    Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;
                    Command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email;
                    Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;

                    if (string.IsNullOrEmpty(ImagePath))
                    {
                        Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = DBNull.Value;
                    }
                    else
                    {
                        Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = ImagePath;
                    }

                    try
                    {
                        Connection.Open();
                        NumberOfRowEffected = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                }
            }

            return NumberOfRowEffected > 0;
        }


        public static bool DeletePerson(int personID)
        {
            
            string query = @"
        BEGIN TRANSACTION;
        BEGIN TRY
            
           
            DELETE T
            FROM Tests AS T
            INNER JOIN TestAppointments AS TA ON T.TestAppointmentID = TA.TestAppointmentID
            INNER JOIN LocalDrivingLicenseApplications AS LDLA ON TA.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID
            INNER JOIN Applications AS A ON LDLA.ApplicationID = A.ApplicationID
            WHERE A.ApplicantPersonID = @PersonID;

           
            DELETE TA
            FROM TestAppointments AS TA
            INNER JOIN LocalDrivingLicenseApplications AS LDLA ON TA.LocalDrivingLicenseApplicationID = LDLA.LocalDrivingLicenseApplicationID
            INNER JOIN Applications AS A ON LDLA.ApplicationID = A.ApplicationID
            WHERE A.ApplicantPersonID = @PersonID;

           
            DELETE LDLA
            FROM LocalDrivingLicenseApplications AS LDLA
            INNER JOIN Applications AS A ON LDLA.ApplicationID = A.ApplicationID
            WHERE A.ApplicantPersonID = @PersonID;
            
           
            DELETE DL
            FROM DetainedLicenses AS DL
            INNER JOIN Licenses AS L ON DL.LicenseID = L.LicenseID
            INNER JOIN Drivers AS D ON L.DriverID = D.DriverID
            WHERE D.PersonID = @PersonID;

           
            DELETE IL
            FROM InternationalLicenses AS IL
            INNER JOIN Drivers AS D ON IL.DriverID = D.DriverID
            WHERE D.PersonID = @PersonID;

            
            DELETE L
            FROM Licenses AS L
            INNER JOIN Drivers AS D ON L.DriverID = D.DriverID
            WHERE D.PersonID = @PersonID;

           
            DELETE FROM Drivers WHERE PersonID = @PersonID;
            DELETE FROM Users WHERE PersonID = @PersonID;
            DELETE FROM Applications WHERE ApplicantPersonID = @PersonID;

            
            DELETE FROM People WHERE PersonID = @PersonID;

            COMMIT TRANSACTION;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION;
           
            THROW; 
        END CATCH;
                         ";

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@PersonID", personID);

                    try
                    {
                        connection.Open();

                        
                        command.ExecuteNonQuery();

                        
                        return true;
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static bool IsPersonExistsByID(int personID)
        {

            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select found=1 from people where PersonID=@personID;";

                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    Command.Parameters.AddWithValue("@personID", personID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                IsFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                }
            }
            return IsFound;
        }


        public static bool IsPersonExistsByNationalNo(string NationalNo)
        {

            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConnectionServer))
            {
                string query = "select found=1 from people where People.NationalNo=@NationalNo;";

                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    Command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                IsFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                }
            }
            return IsFound;
        }

    }

    

}
