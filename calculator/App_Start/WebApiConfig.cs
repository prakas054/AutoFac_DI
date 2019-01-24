using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using calculator.Controllers;
using calculator.Models;
using Autofac.Integration.WebApi;
using System.Reflection;



namespace calculator
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //AUTOFAC

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var configs = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<OperationController>();

            // builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            

            builder.RegisterType<DifferenceModel>().As<ICalculate>().InstancePerLifetimeScope();

            builder.RegisterType<AddModel>().As<ICalculate>().InstancePerLifetimeScope();
            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(configs);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{i}/{j}",
                defaults: new { s = RouteParameter.Optional }
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
