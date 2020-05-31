using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace EmailManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы Web API

            // Используйте "верблюжий" стиль для данных JSON.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Маршруты Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}"
            );
        }
    }
}
