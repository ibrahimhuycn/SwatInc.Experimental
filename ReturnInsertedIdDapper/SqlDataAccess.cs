using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnInsertedIdDapper
{
    public class SqlDataAccess
    {
        public static int SaveData<T>(string storedProcedure, T parameters)
        {
            string CnxString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DapperTestDB;Integrated Security=True";
            using (IDbConnection cnx = new SqlConnection(CnxString))
            {
               var InsertedId =  cnx.QuerySingle<dynamic>(storedProcedure, parameters,commandType:CommandType.StoredProcedure);
               return InsertedId.Id;
            }
        }


    }
}
