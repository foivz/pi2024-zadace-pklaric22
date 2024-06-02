using DBLayer;
using Studentaste.Models;
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
        public static void UpdateBodovi(int studentId, int noviBodovi)
        {
            string sql = $"UPDATE Students SET Bodovi = Bodovi + {noviBodovi} WHERE IdStudent = {studentId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
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
            int bodovi = int.Parse(reader["Bodovi"].ToString());

            var student = new Student
            {
                IdStudent = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                Bodovi = bodovi
            };
            return student;
        }

    }
}
