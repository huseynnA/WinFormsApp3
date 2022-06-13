using System;
using LibForSql;

namespace LibForUser
{
    public class classforUser
    {

        private static string userName { get; set; }
        private static string passWord { get; set; }

        public bool Eque(string Username,string Password) 
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
        //public bool getData(string Username,string Password) 
        //{
        //    if (userName == Username && passWord == Password)
        //    {
        //        return true;
        //    }
        //    else
        //    return false;
        //}
    }

}