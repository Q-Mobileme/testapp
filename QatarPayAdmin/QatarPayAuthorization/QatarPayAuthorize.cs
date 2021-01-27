using QatarPayAdmin.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace QatarPayAdmin.QatarPayAuthorization
{
    public class QatarPayAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var response = actionContext.Request.CreateResponse<ActionResponse>
                                    (new ActionResponse()
                                    {
                                        code = String.Format("{0}", (int)HttpStatusCode.Unauthorized),
                                        success = false,
                                        message = "Not Authorize for this request.",


                                    });
            response.StatusCode = HttpStatusCode.Unauthorized;
            actionContext.Response = response;
        }
    }
}