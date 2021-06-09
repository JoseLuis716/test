using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace test.model
{
    public class DBCommon
    {
        private static string connection = @"Data Source=DESKTOP-5C464J9\SQLEXPRESS;Initial Catalog=catalogo;Integrated Security=True";

        public static IDbConnection Conexion ()
        {
            return new SqlConnection(connection);
        }
    }
}