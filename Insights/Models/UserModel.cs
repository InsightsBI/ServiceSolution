using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insights.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password  { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public int IsActive { get; set; }
        public int  RoleId { get; set; }
    }
}