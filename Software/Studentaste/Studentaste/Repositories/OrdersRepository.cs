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
    public class OrdersRepository
    {
        public static Orders GetOrders(int id)
        {
            Orders orders = null;

            string sql = @"
                SELECT o.IdOrder, o.OrderDate, o.TotalPrice, 
                       s.IdStudent, s.Username
                FROM Orders o
                LEFT JOIN Students s ON o.IdStudent = s.IdStudent
                WHERE o.IdOrder = @id";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                orders = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return orders;
        }

        public static List<Orders> GetOrdersByStudentId(int studentId)
        {
            var orderList = new List<Orders>();

            string sql = @"
                SELECT o.IdOrder, o.OrderDate, o.TotalPrice, 
                       s.IdStudent, s.Username
                FROM Orders o
                LEFT JOIN Students s ON o.IdStudent = s.IdStudent
                WHERE o.IdStudent = " + studentId;  // Filtriranje po studentId
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Orders orders = CreateObject(reader);
                orderList.Add(orders);
            }
            reader.Close();

            DB.CloseConnection();
            return orderList;
        }

        private static Orders CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdOrder"].ToString());
            DateTime orderDate = DateTime.Parse(reader["OrderDate"].ToString());
            decimal totalPrice = decimal.Parse(reader["TotalPrice"].ToString());

            Student student = null;
            if (reader["IdStudent"] != DBNull.Value)
            {
                student = new Student
                {
                    IdStudent = int.Parse(reader["IdStudent"].ToString()),
                    Username = reader["Username"].ToString()
                };
            }

            var orders = new Orders
            {
                IdOrder = id,
                OrderDate = orderDate,
                TotalPrice = totalPrice,
                Student = student
            };

            return orders;
        }
    }
}
