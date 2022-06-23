using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CalculatorAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
                      
            
            //To support multiple GET methods, Added an additional routing
            config.Routes.MapHttpRoute(
                name: "CalcApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            //To support multiple GET methods, Added an additional routing
            //config.Routes.MapHttpRoute(
            //    name: "CalcApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
