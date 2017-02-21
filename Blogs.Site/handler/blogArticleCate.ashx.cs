using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;

namespace Blogs.Site.handler
{
    /// <summary>
    /// blogArticleCate 的摘要说明
    /// </summary>
    public class blogArticleCate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string sql = @"SELECT   id, author, name, remark, statu, isdel, addtime
FROM      BlogArticleCate";
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["blogs"].ConnectionString;
            string connstr = @"date source=D:\WorkRoom\Blogs\db\BlogsDb.db;password=123;";
            DataTable tb = new DataTable();
            using (SQLiteConnection conn=new SQLiteConnection(connstr))
            {
                SQLiteDataAdapter ad = new SQLiteDataAdapter(sql, conn);
                ad.Fill(tb);
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (tb.Rows.Count>0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    sb.Append("<tr>");
                    sb.Append("<td>" + row["id"] + "</td>");
                }
            }
            string 
            string newstr = sb.ToString();
            newstr=newstr.Replace("${trs}", newstr);
            context.Response.Write(newstr);
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