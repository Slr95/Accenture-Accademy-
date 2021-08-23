using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SistemaWebEmpleados.Data;
using SistemaWebEmpleados.Initializer;

namespace SistemaWebEmpleados
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //activar clase inicializadora
            Database.SetInitializer<EmpleadoDbContext>(new EmpleadoDBInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
