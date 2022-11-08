using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поваренок.Classes
{
    public static class ClassSqlConnection
    {
            public static string connectionString = @"Server=LAPTOP\SQLEXPRESS;Database=Kovalchuk02;Trusted_Connection=True";
            public static SqlConnection connection;
            public static int id;
            public static int idRole;
    }
}
