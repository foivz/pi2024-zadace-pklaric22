using DBLayer;
using Studentaste.Models;
using System;
using System.Collections.Generic;
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

        public static List<OrderItems> GetOrderItems(int orderId)
        {
            var orderItemsList = new List<OrderItems>();

            string sql = @"
            SELECT oi.IdOrderItem, oi.Quantity, 
                   d.IdDish, d.Name, d.Description, d.Price
            FROM OrderItems oi
            LEFT JOIN Dishes d ON oi.IdDish = d.IdDish
            WHERE oi.IdOrder = " + orderId;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                OrderItems orderItems = CreateOrderItemObject(reader);
                orderItemsList.Add(orderItems);
            }
            reader.Close();
            DB.CloseConnection();
            return orderItemsList;
        }

        private static OrderItems CreateOrderItemObject(SqlDataReader reader)
        {
            var orderItems = new OrderItems
            {
                IdOrderItem = int.Parse(reader["IdOrderItem"].ToString()),
                Quantity = int.Parse(reader["Quantity"].ToString()),

                Dish = new Dish
                {
                    IdDish = int.Parse(reader["IdDish"].ToString()),
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                    Price = float.Parse(reader["Price"].ToString())
                }
            };

            return orderItems;
        }
    }
}
