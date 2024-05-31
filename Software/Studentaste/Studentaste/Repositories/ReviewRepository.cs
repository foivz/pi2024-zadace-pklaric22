using DBLayer;
using Studentaste.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Studentaste.Repositories
{
    internal class ReviewRepository
    {
        public static void InsertReview(Reviews review)
        {
            string sql = $"INSERT INTO Reviews (TasteRating, QuantityRating, Comment, ReviewDate, IdStudent, IdDish, IdOrder) " +
                         $"VALUES ({review.TasteRating}, {review.QuantityRating}, '{review.Comment}', GETDATE(), {review.Student.IdStudent}, {review.Dishes.IdDish}, {review.Orders.IdOrder})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateReview(Reviews review)
        {
            string sql = $"UPDATE Reviews SET TasteRating = {review.TasteRating}, QuantityRating = {review.QuantityRating}, Comment = '{review.Comment}', " +
                         $"ReviewDate = GETDATE() WHERE IdOrder = {review.Orders.IdOrder} AND IdDish = {review.Dishes.IdDish} AND IdStudent = {review.Student.IdStudent}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteReview(Reviews review)
        {
            string sql = $"DELETE FROM Reviews WHERE IdOrder = {review.Orders.IdOrder} AND IdDish = {review.Dishes.IdDish} AND IdStudent = {review.Student.IdStudent}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static Reviews GetReview(int orderId, int dishId, int studentId)
        {
            string sql = $"SELECT * FROM Reviews WHERE IdOrder = {orderId} AND IdDish = {dishId} AND IdStudent = {studentId}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Reviews review = null;

            if (reader.HasRows)
            {
                reader.Read();
                review = new Reviews
                {
                    IdReview = (int)reader["IdReview"],
                    TasteRating = (int)reader["TasteRating"],
                    QuantityRating = (int)reader["QuantityRating"],
                    Comment = reader["Comment"].ToString(),
                    ReviewDate = (DateTime)reader["ReviewDate"],
                    Student = new Student { IdStudent = (int)reader["IdStudent"] },
                    Dishes = new Dish { IdDish = (int)reader["IdDish"] },
                    Orders = new Orders { IdOrder = (int)reader["IdOrder"] }
                };
            }
            reader.Close();
            DB.CloseConnection();
            return review;
        }

        public static List<Reviews> GetAllReviews()
        {
            var reviewList = new List<Reviews>();

            string sql = @"
        SELECT r.IdReview, r.TasteRating, r.QuantityRating, r.Comment, r.ReviewDate, 
               s.IdStudent, s.Username, 
               d.IdDish, d.Name as DishName, 
               r.IdOrder
        FROM Reviews r
        JOIN Students s ON r.IdStudent = s.IdStudent
        JOIN Dishes d ON r.IdDish = d.IdDish";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Reviews review = CreateReviewObject(reader);
                reviewList.Add(review);
            }
            reader.Close();

            DB.CloseConnection();
            return reviewList;
        }

        private static Reviews CreateReviewObject(SqlDataReader reader)
        {
            return new Reviews
            {
                IdReview = int.Parse(reader["IdReview"].ToString()),
                TasteRating = int.Parse(reader["TasteRating"].ToString()),
                QuantityRating = int.Parse(reader["QuantityRating"].ToString()),
                Comment = reader["Comment"].ToString(),
                ReviewDate = DateTime.Parse(reader["ReviewDate"].ToString()),
                Student = new Student
                {
                    IdStudent = int.Parse(reader["IdStudent"].ToString()),
                    Username = reader["Username"].ToString()
                },
                Dishes = new Dish
                {
                    IdDish = int.Parse(reader["IdDish"].ToString()),
                    Name = reader["DishName"].ToString()
                },
                Orders = new Orders
                {
                    IdOrder = int.Parse(reader["IdOrder"].ToString())
                }

            };

        }
    }
}
