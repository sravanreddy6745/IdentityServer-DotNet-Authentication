using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationModule.Models
{
    public class ServiceExceptionInterceptor : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext context)
        {
            var error = new ErrorDetails()
            {
                StatusCode = 500,
                Message = "Something went wrong! Internal Server Error."
            };

        //Logs your technical exception with stack trace below

        context.Result = new JsonResult(error);
    }

}
}
