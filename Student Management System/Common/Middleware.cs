using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Student_Management_System.Common
{
    public class Middleware
    {
        private readonly RequestDelegate _requestDelegate;
        public Middleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch(Exception exp)
            {
                await httpContext.Response.WriteAsync(exp.ToString());
            }
        }
    }
}
