using Studentaste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;

namespace Studentaste.Repositories
{
    internal class StudentRepository
    {

        public static Student GetStudent(string input)
        {
            string sql;
            if (int.TryParse(input, out int id))
            {
                sql = $"SELECT * FROM Students WHERE IdStudent = {id}";
            }
            else
            {
                sql = $"SELECT * FROM Students WHERE Username = '{input}'";
            }
            return FetchStudent(sql);
        }


        private static Student FetchStudent(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Student student = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return student;
        }

        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdStudent"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var student = new Student
            {
                IdStudent = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return student;
        }

    }
}
