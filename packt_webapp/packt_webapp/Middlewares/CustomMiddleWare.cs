using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace packt_webapp.Middlewares
{
    public class CustomMiddleWare
    {
        private readonly RequestDelegate _next;
        
        public CustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine($" --> Request asked for {httpContext.Request.Path}");

            //Call the next middleware delegate in the pipeline
            await _next.Invoke(httpContext);
        }
    }
}
