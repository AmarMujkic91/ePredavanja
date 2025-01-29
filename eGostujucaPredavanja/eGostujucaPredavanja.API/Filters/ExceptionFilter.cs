using eGostujucaPredavanja.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace eGostujucaPredavanja.API.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute //middleware ili neko zove filter 
    {
        ILogger<ExceptionFilter> _logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, context.Exception.Message);
            if (context.Exception is UserException)
            {
                context.ModelState.AddModelError("userError",context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest; //status 400
            }
            else
            {
                context.ModelState.AddModelError("ERROR", "Server sider error, please check logs");
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError; //status 500
            }

            // pretvorit u jSon

            // ToDictionary() Key value klasa, gdje mi kazemo stta nam je key(npr userError ili ERROR) a value je sve sto se nalazi pod tim keyem
            var list = context.ModelState.Where(x => x.Value.Errors.Count() > 0)
                   .ToDictionary(x => x.Key, y => y.Value.Errors.Select(z => z.ErrorMessage));

            context.Result = new JsonResult(new { errors = list });

        }
    }
}
