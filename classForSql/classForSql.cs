using System;
using System.Data.SqlClient;

namespace LibForSql
{
    public class DataBaseWorker

    {
        private const string connstring = @"Server=DESKTOP-VUNF03K\SqlExpress;Database=dev;Encrypt=false;Trusted_Connection=True;";
        SqlConnection sqlConnection = new SqlConnection(connstring);
        SqlCommand sqlCommand1 = new SqlCommand();
        string cmd;

        public  void InsertSQL(string name,string surname,int age,string password) 
        {
            sqlConnection.Open();
             cmd = @$"INSERT INTO Users2 (Name,Surname,Age,Password
    Values('{name}','{surname}',{age},'{password}'))
)";

            sqlCommand1 = new SqlCommand(this.cmd,sqlConnection );
            sqlCommand1.BeginExecuteNonQuery();

            sqlConnection.Close();
        }

       
        public static void Select(SqlDataReader sqlDataReader) 
        {
            
        }
    }
}
