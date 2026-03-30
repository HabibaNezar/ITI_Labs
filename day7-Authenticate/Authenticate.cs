using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_Authenticate
{
    internal class Authenticate
    {   // fields

        // propery
        public Student student { get; set; }

        // constructors
        public Authenticate( Student s)
        {
            student = s;
        }

        // methods
        
        // loginMethod overloads
        public bool loginMethod(string username, string password, string email)
        {
            return (student.Username == username &&
                    student.Userpass == password &&
                    student.Email == email);
        }

        public bool loginMethod(string email, string password)
        {
            return (student.Email == email &&
                    student.Userpass == password);
        }

        public bool loginMethod(int id, string password)
        {
            return (student.ID == id &&
                    student.Userpass == password);
        }

        /*public bool loginMethod(int id, string email)
        {
            return (student.ID == id &&
                    student.Email == email);
        }*/
        // forgetPassword overloads
        public string forgetPassword(string username)
        {
            if (student.Username == username)
                return student.Userpass;
            else
                return "user not found !";
        }

        public string forgetPassword(string email, int id)
        {
            if (student.Email == email && student.ID == id)
                return student.Userpass;
            else
                return "user not found !";
        }

        public string forgetPassword(int id)
        {
            if (student.ID == id)
                return student.Userpass;
            else
                return "user not found !";
        }

        // ResetPassword overloads

        public bool ResetPassword(int id, string oldPass, string newPass)
        {
            if (student.ID == id && student.Userpass == oldPass)
            {
                student.Userpass = newPass;
                return true;
            }
            return false;
        }

        public bool ResetPassword(string email, string oldPass, string newPass)
        {
            if (student.Email == email && student.Userpass == oldPass)
            {
                student.Userpass = newPass;
                return true;
            }
            return false;
        }

        public bool ResetPassword(int id, string username, string oldPass, string newPass)
        {
            if (student.ID == id &&
                student.Username == username &&
                student.Userpass == oldPass)
            {
                student.Userpass = newPass;
                return true;
            }
            return false;
        }

    }
}
