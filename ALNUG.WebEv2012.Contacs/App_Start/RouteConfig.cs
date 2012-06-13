using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace ALNUG.WebEv2012.Contacs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapHttpRoute(
                name: "numbersByContactID",
                routeTemplate: "api/contacts/{contactID}/contactNumbers",
                defaults: new { controller = "contactNumbers", action = "GetByContactID" },
                constraints: new
                    {
                        contactID = @"\d+",
                        httpMethod = new HttpMethodConstraint(new string[] { "Get" })
                    }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}