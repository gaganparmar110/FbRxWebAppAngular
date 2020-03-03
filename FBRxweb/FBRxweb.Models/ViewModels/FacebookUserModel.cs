
using System;
using System.Collections.Generic;
using System.Text;

namespace FBRxweb.Models.ViewModels
{
    public class FacebookUserModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public System.DateTime DateOfBirth { get; set; }
        public int GenderAO { get; set; }

        public System.DateTimeOffset CreatedDateTime { get; set; }

        public bool LoginStatus { get; set; }

        public FacebookUserModel()
        {
        }
    }

}