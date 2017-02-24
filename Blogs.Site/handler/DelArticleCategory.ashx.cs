using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Blogs.Site.handler
{
    /// <summary>
    /// DelArticleCategory 的摘要说明
    /// </summary>
    public class DelArticleCategory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string httpMethod= context.Request.HttpMethod.ToLower();
            int result;
            if (httpMethod=="get")
            {

            }
            if (httpMethod=="post")
            {
                string name= HttpContext.Current.Request.Params["chk"].Trim().ToString();
                //string sql = @"UPDATE  BlogArticleCategory  SET  isdel = 1  WHERE  (id IN ($name))";
                string connstr = @"data source=D:\WorkRoom\Blogs\db\BlogsDb.db;password=123";
                //SQLiteParameter ps = new SQLiteParameter("$name",name);
                using (SQLiteConnection conn = new SQLiteConnection(connstr))
                {
                    using (SQLiteCommand com=new SQLiteCommand(conn))
                    {
                        com.CommandText = "UPDATE  BlogArticleCategory  SET  isdel = 1  WHERE  (id IN ("+name+"))";
                        
                        //com.Parameters.Add(ps);
                        conn.Open();
                        result= com.ExecuteNonQuery();
                        string str=com.CommandText.ToString();
                    }
                }
                if (result>0)
                {

                    context.Response.Write("<script>alert('删除："+result+"条数据');window.location='BlogArticleCategory.ashx';</script>");
                }
                if (result<=0)
                {
                    context.Response.Write("<script>alert('删除：" + result + "条数据');window.location='BlogArticleCategory.ashx';</script>");
                }
                
            }
            
           
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