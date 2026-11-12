using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public interface IUser
    {
        string GetUsername();
        void SetUsername(string username);

        string GetUser_id();
        void SetUser_id(string user_id);

        string GetEmail();
        void SetEmail(string email);

        string GetPassword();
        void SetPassword(string password);
    }
}