using Insights.DataLayer;
using Insights.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Insights.Controllers
{
    public class SQLController : ApiController
    {
        [Route("api/sqlcontroller/{data}")]
        [HttpPost]
        public string CheckConnection(SQLModel param)
        {
            string connectionString = string.Format("initial catalog={0};User ID={1};Password={2}", param.Servername, param.UserName, param.Password);
            RuntimeConnectionString helper = new RuntimeConnectionString(connectionString);
            if(helper.IsConnection)
            {
                return "Test Connection Succeeded";
            }else
            {
                return "fail";
            }
            
        }
        
    }
}
