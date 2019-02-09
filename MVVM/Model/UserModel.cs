using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class UserModel { }

    public class User : ValidationBase
    {
        private string username;
        private string password;
        private List<Image> images = new List<Image>();

        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public List<Image> Images
        {
            get { return images; }
            set
            {
                if (images != value)
                {
                    images = value;
                    OnPropertyChanged("Images");
                }
            }
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.username))
            {
                this.ValidationErrors["Username"] = "Username is required.";
            }
            else if (Regex.IsMatch(this.username, @"^\d"))
            {
                this.ValidationErrors["Username"] = "Can't start with a number.";
            }
            if (string.IsNullOrWhiteSpace(this.password))
            {
                this.ValidationErrors["Password"] = "Password is required.";
            }
            else if (this.password.Length < 6)
            {
                this.ValidationErrors["Password"] = "Password too short (<6).";
            }
        }
    }
}
