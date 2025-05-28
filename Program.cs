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
        static string connectionString = "Server=LAPTOP-TANOHAT6; Database=ContactsDB; Integrated Security=True;";

        public static void AddNewContact(stContact contact)
        {
           SqlConnection sqlConnection = new SqlConnection(connectionString);


            string sqlQuery = "INSERT INTO [dbo].[Contacts]" +
                " ([FirstName],[LastName],[Email],[Phone],[Address],[CountryID]) " +
                " VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

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
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record Inserted Successfully.");
                }
                else 
                {
                    Console.WriteLine("Record Insertion Failed.");
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
            stContact stContact = new stContact()
            {
                FirstName = "Ahmad",
                LastName = "Mahmoud",
                Email = "AhmadMahmoud@gmail.com",
                Phone =  "08080904",
                Address =  "Syria",
                CountryID = 2
            };
            AddNewContact(stContact);
            
            Console.ReadKey();
        }
    }
}
