using System;
using System.Data.SqlClient;

namespace testMono
{
    public class TestConnection
    {

        public static void start() {

            MainClass.WriteLine(nameof(TestConnection) + ": ", "start");
            try
            {
                checkMsSqlConnection();
                MainClass.WriteLine("MsSQL: ", "Ok");
            }
            catch (Exception e){
                MainClass.WriteErrorLine("MsSQL: ", "failed", e.Message);
            }

            try{
                checkPgSqlConnection();
                MainClass.WriteLine("PostgreSQL: ", "Ok");
            }
            catch (Exception e){
                MainClass.WriteErrorLine("PostgreSQL: ", "failed", e.StackTrace);
            }
            MainClass.WriteLine(nameof(TestConnection) + ": ", "finish");
        }

        static void checkMsSqlConnection()
        {
            var mssqlConnection = new SqlConnection(Config.msSqlConnectionString);
            mssqlConnection.Open();
            mssqlConnection.Dispose();
        }

        static void checkPgSqlConnection()
        {
            var npgsqlConnection = new Npgsql.NpgsqlConnection(Config.pgSqlConnectionString);
            npgsqlConnection.Open();
            npgsqlConnection.Dispose();
        }
    }
}
