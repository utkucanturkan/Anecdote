using Shared.Exceptions;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Anectode.WebService.Filters
{
    public class AnecdoteExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is AnecdoteException)
            {
                AnecdoteException exception = ((AnecdoteException)actionExecutedContext.Exception);

                HttpError error = new HttpError();
                error.Add("ExceptionMessage", exception.Message);
                error.Add("ExceptionType", exception.Source);
                //error.Add("StackTrace", exception.StackTrace);

                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(exception.StatusCode, error);

            }
        }
    }
}