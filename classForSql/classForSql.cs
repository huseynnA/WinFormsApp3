using System;
using System.Data.SqlClient;

namespace LibForSql
{
    public  class classForSql

    {
        private const string connstring = @"Server=DESKTOP-VUNF03K\SqlExpress;Database=dev;Encrypt=false;Trusted_Connection=True;";


         static classForSql() 
        {
            SqlConnection  sqlConnection = new SqlConnection(connstring);
            classForSql.OpenSql(sqlConnection); 
        }
        
        public static void OpenSql( SqlConnection sqlConnection) 
        {
            sqlConnection.Open();
        }

        public static void InsertSQL(SqlConnection sqlConnection,string name,string username,int age,string password) 
        {
            string cmd = @$"INSERT INTO Users 
                         VALUES({name},{username},{age},{password})
                                ";

            SqlCommand sqlCommand = new SqlCommand(cmd,sqlConnection);
            sqlCommand.BeginExecuteNonQuery();
        }
    }
}
