using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Routing;
using System.Web.UI;

namespace Food_recipe {
    public class Customroute : IRouteHandler {
        public IHttpHandler GetHttpHandler(RequestContext requestContext) {
            string requestedUrl = requestContext.HttpContext.Request.Path;
            if (!string.IsNullOrEmpty(requestedUrl)) {
                string rewrittenUrl = requestedUrl.Replace(".aspx", string.Empty);
                HttpContext.Current.RewritePath(rewrittenUrl);
            }

            return BuildManager.CreateInstanceFromVirtualPath(requestedUrl, typeof(Page)) as IHttpHandler;
        }
    }
}