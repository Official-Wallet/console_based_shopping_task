using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public class User
    {
        
        private string username;

        private string user_id;

        private string email;

        private string password;

        public string GetUsername()
        {
            
            return this.username;

        }

        public void SetUsername(string username)
        {
            
            this.username = username;

        }

        public string GetUser_id()
        {
            
            return this.user_id;

        }

        public void SetUser_id(string user_id)
        {
            
            this.user_id = user_id;

        }

        public string GetEmail()
        {
            
            return this.email;

        }

        public void SetEmail(string email)
        {
            
            this.email = email;

        }

        public string GetPassword()
        {
            
            return this.password;

        }

        public void SetPassword(string password)
        {
            
            this.password = password;

        }

        public User(string username, string user_id, string email, string password)
        {

            this.username = username;

            this.user_id = user_id;

            this.email = email;

            this.password = password;

        }

    }

}