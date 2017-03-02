using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Sockets;

namespace Blogs.Site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.UrlReferrer.ToString();
            Response.Write(url+"<br/>");
            string url2 = Request.Url.ToString();
            Response.Write(url2+ "<br/>");
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获得本地ip
            //string localIp=s.LocalEndPoint.ToString();
            //string ip = s.RemoteEndPoint.ToString();
            string ip2 = Request.UserHostAddress;
            Response.Write(ip2 + "<br/>");

        }
    }
}