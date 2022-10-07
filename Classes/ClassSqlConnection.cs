using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Поваренок.View
{
    class ClassSqlConnection
    {
        public static string connectionString = @"Data Source = localhost; Initial Catalog = DBKovalchukAnya02; Integrated Security = true";
        public static ClassSqlConnection sqlConnection;
    }
}
