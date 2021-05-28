using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Helpers
{
    static class DapperHelper<T>
    {
        private static readonly DynamicParameters Parameters = new DynamicParameters();
        public static int ExecuteNonQuery(string connectionString, string commandText)
        {
            var connection = new SqlConnection(connectionString);
            return connection.Execute(commandText, Parameters);
        }
        public static void AddParameter(string text1, string text2)
        {
            Parameters.Add(text1, text2);
        }
        public static IEnumerable<T> ExecuteQuery(string connectionString, string commandText)
        {
            var connection = new SqlConnection(connectionString);
            var emp = connection.Query<T>(commandText, Parameters).ToList();
            foreach (var e in emp)
            {
                yield return e;
            }
        }
    }
}
