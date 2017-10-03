using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Insights.DataLayer.Tables;
using Newtonsoft.Json.Linq;
using Insights.Models;

namespace Insights.Controller
{
    public class UserController : ApiController
    {
        [Route("api/usercontroller/{data}")]
        [HttpPost]
       public void  StoreUserDetails(UserModel data)
        {
            //User tableData = new DataLayer.Tables.User
            //{
            //    UserId = data.UserId,
            //    FirstName = data.FirstName,
            //    LastName = data.LastName,
            //    UserName = data.UserName,
            //    Password = data.Password,
            //    CreatedDate = data.CreatedDate,
            //    UpdatedDate = data.UpdatedDate,
            //    IsActive = data.IsActive
            //};
            using (var tableEntity = new insightbiModelEntities())
            {
               

                tableEntity.Users.Add(tableData);
                tableEntity.SaveChanges();

            }
          
        }
        [Route("api/usercontroller/{id}")]
        [HttpGet]
        public User GetUserDetails(int id)
        {
            
            insightbiModelEntities tableEntity = new insightbiModelEntities();
            tableEntity.Users.Where(t => t.UserId == id);
            User u = new User();
            return u;
        }
    }
}
