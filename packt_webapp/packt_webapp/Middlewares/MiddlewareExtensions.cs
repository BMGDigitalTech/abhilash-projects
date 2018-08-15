using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace packt_webapp.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleWare>();
        }
    }
}
