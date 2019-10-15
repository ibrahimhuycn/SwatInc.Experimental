using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ReturnInsertedIdDapper
{
    public class SqlDataAccess
    {
        public static readonly string CnxString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DapperTestDB;Integrated Security=True";

        public static int SaveData<T>(string storedProcedure, T parameters)
        {
            using (IDbConnection cnx = new SqlConnection(SqlDataAccess.CnxString))
            {
                var InsertedId = cnx.QuerySingle<dynamic>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return Convert.ToInt32(InsertedId.Id);
            }
        }


        public static List<T> LoadData<T>(string storedProcedure)
        {
            //Dim Output As List(Of LisRequestDataModel) = cnn.Query(Of LisRequestDataModel)("SELECT * FROM [AnalysisRequest] LIMIT 1")
            //Return Output.ToList


            string CnxString = SqlDataAccess.CnxString;

            using (IDbConnection cnx = new SqlConnection(CnxString))
            {
                var rows = cnx.Query<T>(storedProcedure, commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }

        }

    }
}
