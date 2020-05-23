using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AZUXlib.DataAccess
{
    public class GenericDataAccess
    {
        public static T Find<T>(int id)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var findCategory = new DynamicParameters();
                findCategory.Add("@Id", id);

                var query = "SELECT * FROM " + typeof(T).Name + " WHERE Id = @Id";
                var output = cnn.Query<T>(query, findCategory).ToList();
                return output[0];
            }
        }

        public static int Delete<T>(int id)
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var findCategory = new DynamicParameters();
                findCategory.Add("@Id", id);

                var query = "DELETE FROM " + typeof(T).Name + " WHERE Id = @Id";
                var output = cnn.Execute(query, findCategory);
                return output;
            }
        }

        public static List<T> FindAll<T>()
        {
            using (var cnn = new SQLiteConnection(Helper.GetCnnStr()))
            {
                var findCategory = new DynamicParameters();

                var query = "SELECT * FROM " + typeof(T).Name;
                var output = cnn.Query<T>(query, findCategory).ToList();
                return output;
            }
        }
    }
}
