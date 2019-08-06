﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FluentApi.Attributes;
using FluentValidation.WebApi;

namespace FluentApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new ModelValidationFilterAttribute());

            // Конфигурация и службы веб-API
            FluentValidationModelValidatorProvider.Configure(config);

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
