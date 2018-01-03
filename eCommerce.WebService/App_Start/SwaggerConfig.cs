using System.Web.Http;
using WebActivatorEx;
using eCommerce.WebService;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace eCommerce.WebService
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "eCommerce.WebService Api");
                })
                .EnableSwaggerUi(c =>
                    {
                        c.InjectJavaScript(thisAssembly, "");
                    });
        }
    }
}