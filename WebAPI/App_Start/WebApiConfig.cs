using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"


            );

            using (SqlConnection conn = new SqlConnection("Server=tcp:programacaoweb.database.windows.net,1433;Database=programacaoweb;User ID=alunos@programacaoweb;Password=web1234$;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
            }
        }
    }
}
