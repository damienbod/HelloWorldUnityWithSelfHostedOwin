using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using HelloWorldUnityWithSelfHostedOwin.Business;
using Microsoft.Practices.Unity;

namespace HelloWorldUnityWithSelfHostedOwin.Filters
{
    public class MyCustomFilterAttribute : ActionFilterAttribute
    {
        [Dependency]
        public IBusinessClass ServiceB { get; set; }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // pre-processing
            ServiceB.Hello();
        }
 
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var objectContent = actionExecutedContext.Response.Content as ObjectContent;
            if (objectContent != null)
            {
                var type = objectContent.ObjectType; //type of the returned object
                var value = objectContent.Value; //holding the returned value
            }
 
            //DO Something
        }
    }
}
