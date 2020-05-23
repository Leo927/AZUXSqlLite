using AZUXlib.Models;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace AZUXlib.DataAccess
{
    public class ProductAccess
    {
        public static int Insert(Product product)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var query = "INSERT INTO Product " +
                    "(ProductName, CategoryId, DefaultPrice, MaximumRetailPrice) " +
                    "VALUES(@ProductName, @CategoryId, @DefaultPrice, @MaximumRetailPrice)";
                int affectedRows = cnn.Execute(query, product);
                return affectedRows;
            }
        }

        public static void Update(int id, Product product)
        {
            product.Id = id;
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var query = "UPDATE Product " +
                    "SET ProductName = @ProductName " +
                    ", CategoryId = @CategoryId " +
                    ", DefaultPrice = @DefaultPrice " +
                    ", MaximumRetailPrice = @MaximumRetailPrice " +
                    "WHERE Id = @Id";
                cnn.Execute(query, product);
            }
        }

        public static List<Product> Find(string keyword)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var findCategory = new DynamicParameters();
                findCategory.Add("@SearchKeyWord", "%" + keyword + "%");

                var query = "SELECT * FROM Product WHERE ProductName LIKE @SearchKeyWord";
                var output = cnn.Query<Product>(query, findCategory).ToList();
                output.ForEach(x => x.Category = CategoryAccess.Find(x.CategoryId));
                return output;

            }
        }

        public static Product Find(int id)
        {
            var output = Helper.Find<Product>(id);
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                output.Category = CategoryAccess.Find(output.CategoryId);
            }
            return output;
        }

        public static int Delete(int id)
        {
            return Helper.Delete<Product>(id);
        }
    }
}
