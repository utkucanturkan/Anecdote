using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Anectode.WebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Custom Exception Filter (Globally)
            config.Filters.Add(new Filters.AnecdoteExceptionFilterAttribute());
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
