using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogs.Site.handler
{
    /// <summary>
    /// EditArticleCategory 的摘要说明
    /// </summary>
    public class EditArticleCategory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string id=HttpContext.Current.Request.QueryString["id"];

            context.Response.Write("Hello World"+id);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}