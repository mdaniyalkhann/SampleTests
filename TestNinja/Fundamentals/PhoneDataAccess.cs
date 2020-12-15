using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using TestNinjaOther;

namespace TestNinja.Fundamentals
{
    public class PhoneEntity : DbContext
    {
        public void Initialize()
        {
            Console.WriteLine("Initialize DB Context");
        }

        public override string ToString()
        {
            return "It is DB Context";
        }
    }

    public class PhoneDataAccess
    {
        private void SetId(int id = -1)
        {
            Id.Add(id);
        }

        public IList<int> Id { get; } = new List<int>();

        public void GetPhoneNumber()
        {
            string a = "abc";

            if (a == "abc")
            {
                a = "cde";
            }
            else
            {
                a = "mnm";
            }

            switch (a)
            {
                case "a" + "a":
                case "b": break;
            }

            Id.Clear();
            var connection = new SqlConnection();
            Console.WriteLine(new PhoneEntity().ToString());
            var phoneNumber = PhoneNumber.Parse("0123456789");
            var fizzBuz = FizzBuzz.GetOutput(15);
            connection = new SqlConnection();

            var command = new SqlCommand
            {
                Connection = connection
            };

            connection.Open();
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Area), phoneNumber.PhoneDto.Area + "1");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Area), phoneNumber.PhoneDto.Area + "2");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Area), phoneNumber.PhoneDto.Area + "3");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Area), phoneNumber.PhoneDto.Area + "4");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "5");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "6");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "7");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "8");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "9");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "10");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major + "11");
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Major), phoneNumber.PhoneDto.Major);
            command.Parameters.AddWithValue(nameof(phoneNumber.PhoneDto.Minor), phoneNumber.PhoneDto.Minor);
            command.Parameters.AddWithValue(nameof(phoneNumber.ToString), phoneNumber.ToString());
            command.Parameters.AddWithValue(nameof(FizzBuzz), fizzBuz);
            command.ExecuteScalar();
            connection.Close();
            command.Dispose();

            SetId(1);
        }

        public void SavePhoneNumber()
        {
            Id.Clear();
            var fizzBuz = FizzBuzz.GetOutput(15);
            var command = new SqlCommand("some_store_procedure");
            command.Parameters.AddWithValue(string.Empty, string.Empty);
            command.Parameters.AddWithValue(nameof(FizzBuzz), fizzBuz);

            Id.Add(command.ExecuteNonQuery());
        }
    }
}
