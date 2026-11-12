using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public class User: IUser
    {
        
        private string Username;

        private string User_id;

        private string Email;

        private string Password;

        public string GetUsername()
        {
            
            return this.Username;

        }
        
        public void SetUsername(string username)
        {
            
            this.Username = username;

        }

        public string GetUser_id()
        {
            
            return this.User_id;

        }
        
        public void SetUser_id(string user_id)
        {
            
            this.User_id = user_id;

        }

        public string GetEmail()
        {
            
            return this.Email;

        }
        
        public void SetEmail(string email)
        {
            
            this.Email = email;

        }

        public string GetPassword()
        {
            
            return this.Password;

        }
        
        public void SetPassword(string password)
        {
            
            this.Password = password;

        }

        public User(string username, string user_id, string email, string password)
        {

            this.Username = username;

            this.User_id = user_id;

            this.Email = email;

            this.Password = password;

        }
    
    }

}