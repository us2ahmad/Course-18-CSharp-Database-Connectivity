using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Course_18
{
    struct stContact
    {
        public int ID {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
      
    }

    internal class Program
    {
        static string connectionString = "Server = LAPTOP-TANOHAT6; Database = ContactsDB; Integrated Security = True;";

                public static void PrintAllContacts()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString: ConnectionString);
            string sqlQuery = "SELECT * FROM Contacts";

            SqlCommand  command = new SqlCommand(sqlQuery, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
              
                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            { 
                sqlConnection.Close(); 
            }

        }
        public static void PrintAllContactsWithFirstName(string FirstName)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString: ConnectionString);
            string sqlQuery = "SELECT * FROM Contacts WHERE FirstName = @FirstName";

            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@FirstName", FirstName); 

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static void PrintAllContactsWithFirstNameAndCountry(string FirstName,short CountryID)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString: ConnectionString);
            string sqlQuery = "SELECT * FROM Contacts WHERE FirstName = @FirstName AND CountryID = @CountryID";
            
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static void SearchContactsStartsWith(string StartsWith)
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM Contacts WHERE FirstName LIKE '' + @StartsWith +'%'";


            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@StartsWith", StartsWith);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static void SearchContactsEndsWith(string StartsWith)
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @StartsWith +'' ";


            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@StartsWith", StartsWith);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static void SearchContactsContains(string StartsWith)
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @StartsWith + '%' ";


            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@StartsWith", StartsWith);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Contact ID : {(int)reader["ContactID"]}");
                    Console.WriteLine($"First Name : {(string)reader["FirstName"]}");
                    Console.WriteLine($"Last Name : {(string)reader["LastName"]}");
                    Console.WriteLine($"Email : {(string)reader["Email"]}");
                    Console.WriteLine($"Phone : {(string)reader["Phone"]}");
                    Console.WriteLine($"Address : {(string)reader["Address"]}");
                    Console.WriteLine($"Country ID : {(int)reader["CountryID"]}");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static string GetFirstName(int ContactID)
        {
            SqlConnection sqlConnection= new SqlConnection(ConnectionString);

            string FirstName = string.Empty;
            string sqlQuery = "SELECT FirstName From Contacts WHERE ContactID = @ContactID";

            SqlCommand command  = new SqlCommand(sqlQuery,sqlConnection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
          
            try
            {
                sqlConnection.Open();
                object result = command.ExecuteScalar();
               
                if(result != null)
                {
                    FirstName = result.ToString();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

            return FirstName;
        }
        public static bool FindContactByID(int ContactID,ref stContact contact)
        {
            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            string sqlQuery = "SELECT * FROM Contacts WHERE ContactID = @ContactID";
            
            SqlCommand command = new SqlCommand( sqlQuery,sqlConnection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.Read())
                {
                    isFound = true;

                    contact.ID = reader.GetInt32(0);
                    contact.FirstName = reader.GetString(1);
                    contact.LastName = reader.GetString(2);
                    contact.Email = reader.GetString(3);
                    contact.Phone = reader.GetString(4);
                    contact.Address = reader.GetString(5);
                    contact.CountryID = reader.GetInt32(6);
                }
                reader.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }

            return isFound;
        }

        
        public static void AddNewContactAndGetID(stContact contact)
        {
           SqlConnection sqlConnection = new SqlConnection(connectionString);


            string sqlQuery = @" INSERT INTO [dbo].[Contacts] " +
                               " ([FirstName],[LastName],[Email],[Phone],[Address],[CountryID]) " +
                               " VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID); " +
                               " SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);

            command.Parameters.AddWithValue("@FirstName", contact.FirstName);
            command.Parameters.AddWithValue("@LastName", contact.LastName);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.Phone);
            command.Parameters.AddWithValue("@Address", contact.Address);
            command.Parameters.AddWithValue("@CountryID", contact.CountryID);

            try
            {
                sqlConnection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int insertedID))
                {
                    Console.WriteLine($"New inserted ID :  {insertedID}");
                }
                else 
                {
                    Console.WriteLine(" Failed to retrieve the inserted ID");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        static void Main(string[] args)
        {
                //PrintAllContacts();
    //PrintAllContactsWithFirstName("John");
    //PrintAllContactsWithFirstNameAndCountry("John", 1);

    //Console.WriteLine("--------Contacts starts with 'j'");
    //SearchContactsStartsWith("j");

    //Console.WriteLine("-------Contacts Ends with 'ne'");
    //SearchContactsEndsWith("ne");

    //Console.WriteLine("-------Contacts Contains with 'ae'");
    //SearchContactsContains("ae");

    //Console.WriteLine(GetFirstName(1));

    //stContact contact = new stContact();    
    //if(FindContactByID(22,ref contact))
    //{
    //    Console.WriteLine($"Contact ID : {contact.ID}");
    //    Console.WriteLine($"First Name : {contact.FirstName}");
    //    Console.WriteLine($"Last Name : {contact.LastName}");
    //    Console.WriteLine($"Email : {contact.Email}");
    //    Console.WriteLine($"Phone : {contact.Phone}");
    //    Console.WriteLine($"Address : {contact.Address}");
    //    Console.WriteLine($"Country ID : {contact.CountryID}");
    //    Console.WriteLine("----------------------------------------------------------");
    //}
    //else
    //{
    //    Console.WriteLine("Not Found");
    //}

            stContact stContact = new stContact()
            {
                FirstName = "Ahmed",
                LastName = "Sami",
                Email = "AhmedSami@gmail.com",
                Phone =  "96955",
                Address =  "Egypt",
                CountryID = 1
            };
            AddNewContactAndGetID(stContact);
            
            Console.ReadKey();
        }
    }
}
