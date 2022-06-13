using System;
using LibForSql;

namespace LibForUser
{
    public class classforUser
    {

        private static string userName { get; set; }
        private static string passWord { get; set; }

        public bool Eque(string Username,string Password) // for login
        {
            userName = Username;
            passWord = Password;
            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            if (dataBaseWorker.Select(userName, passWord)) 
            {
                return true;
            }
           else return false;
        }
        public bool getData(string name, string surname, int age, string password)
        {
            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            try
            {
                dataBaseWorker.InsertSQL(name, surname, Convert.ToInt32(age), password);
                return true;
            }
            catch (Exception e) 
            {
                return false;
            }

        }
    }

}