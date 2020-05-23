using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using AZUXlib.Models;
namespace AZUXlib.DataAccess
{
    public class CategoryAccess
    {
        public static int Insert(string categoryName)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var newCategory = new DynamicParameters();
                newCategory.Add("@CategoryName", categoryName);

                var query = "INSERT INTO Category (CategoryName) VALUES(@CategoryName)";
                int affectedRows = cnn.Execute(query, newCategory);
                return affectedRows;
            }
        }

        public static void Update(int id, string categoryName)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var query = "UPDATE Category " +
                    "SET CategoryName = @CategoryName " +
                    "WHERE Id = @Id";
                cnn.Execute(query, new Category(categoryName) { Id = id });
            }
        }

        public static List<Category> Find(string keyword)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var findCategory = new DynamicParameters();
                findCategory.Add("@CategoryName", "%"+keyword+"%");

                var query = "SELECT * FROM Category WHERE CategoryName LIKE @CategoryName";
                var output = cnn.Query<Category>(query, findCategory).ToList();
                return output;
            }
        }

        public static Category Find(int id)
        {
            return Helper.Find<Category>(id);
        }
    }
}
