using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Insights
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional, controller= "UserController" }
            );
            config.Routes.MapHttpRoute(
                name: "SQLConnectionApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "SQLController" }
            );
        }
    }
}
