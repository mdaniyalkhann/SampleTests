using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TestNinja.Fundamentals
{
    public class PhoneDataAccess
    {
        private void SetId(int id = -1)
        {
            Id.Add(id);
        }

        public IList<int> Id { get; } = new List<int>();

        public void GetPhoneNumber()
        {
            Id.Clear();
            var connection = new SqlConnection();
            var phoneNumber = PhoneNumber.Parse("0123456789");
            var fizzBuz = FizzBuzz.GetOutput(15);
            connection = new SqlConnection();

            var command = new SqlCommand
            {
                Connection = connection
            };

            connection.Open();
            command.Parameters.AddWithValue(nameof(phoneNumber.Area), phoneNumber.Area);
            command.Parameters.AddWithValue(nameof(phoneNumber.Major), phoneNumber.Major);
            command.Parameters.AddWithValue(nameof(phoneNumber.Minor), phoneNumber.Minor);
            command.Parameters.AddWithValue(nameof(FizzBuzz), fizzBuz);
            command.ExecuteScalar();
            connection.Close();
            command.Dispose();

            SetId(1);
        }

        public void SavePhoneNumber()
        {
            Id.Clear();
            var command = new SqlCommand("some_store_procedure");
            command.Parameters.Add(string.Empty);

            Id.Add(command.ExecuteNonQuery());
        }
    }
}
