using System.Data;
using System.Data.SqlClient;

namespace LibForSql
{
    public class DataBaseWorker

    {
        private const string connstring = @"Server=DESKTOP-VUNF03K\SqlExpress;Database=dev;Encrypt=false;Trusted_Connection=True;";
        SqlConnection sqlConnection = new SqlConnection(connstring);
        SqlCommand sqlCommand1 = new SqlCommand();
        SqlDataReader dataReader;
        string cmd;

        SqlDataAdapter adpt;
        DataTable dt;

        public void InsertSQL(string name, string surname, int age, string password)
        {
            sqlConnection.Open();
            cmd = @$"INSERT INTO Users2 (Name,Surname,Age,Password)
    Values('{name}','{surname}',{age},'{password}')
";

            sqlCommand1 = new SqlCommand(cmd, sqlConnection);
            sqlCommand1.BeginExecuteNonQuery();
            sqlConnection.Close();
        }


        public bool Select(string name, string password)
        {
            cmd = @$"SELECT * FROM USERS2 
Where Name='{name}' and Password='{password}'
";
            sqlCommand1 = new SqlCommand(cmd, sqlConnection);
            sqlConnection.Open();
            dataReader=sqlCommand1.ExecuteReader();


            if (dataReader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            else 
            {
                sqlConnection.Close();
                return false;
            }
           
        }
    }
}
