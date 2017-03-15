using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace Blogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogCommentArticleDAL
	/// </summary>
	public partial class BlogCommentArticleDAL
	{
		public BlogCommentArticleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("cmaid", "BlogCommentArticle"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int cmaid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogCommentArticle");
			strSql.Append(" where cmaid=@cmaid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmaid", DbType.Int32,4)
			};
			parameters[0].Value = cmaid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Blogs.Model.BlogCommentArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogCommentArticle(");
			strSql.Append("cmaarticle,cmaauthor,cmatitle,cmacontent,cmaaddtime,cmaisdel)");
			strSql.Append(" values (");
			strSql.Append("@cmaarticle,@cmaauthor,@cmatitle,@cmacontent,@cmaaddtime,@cmaisdel)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmaarticle", DbType.Int32,4),
					new SQLiteParameter("@cmaauthor", DbType.Int32,4),
					new SQLiteParameter("@cmatitle", DbType.String),
					new SQLiteParameter("@cmacontent", DbType.String),
					new SQLiteParameter("@cmaaddtime", DbType.DateTime),
					new SQLiteParameter("@cmaisdel", DbType.Boolean)};
			parameters[0].Value = model.cmaarticle;
			parameters[1].Value = model.cmaauthor;
			parameters[2].Value = model.cmatitle;
			parameters[3].Value = model.cmacontent;
			parameters[4].Value = model.cmaaddtime;
			parameters[5].Value = model.cmaisdel;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Blogs.Model.BlogCommentArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogCommentArticle set ");
			strSql.Append("cmaarticle=@cmaarticle,");
			strSql.Append("cmaauthor=@cmaauthor,");
			strSql.Append("cmatitle=@cmatitle,");
			strSql.Append("cmacontent=@cmacontent,");
			strSql.Append("cmaaddtime=@cmaaddtime,");
			strSql.Append("cmaisdel=@cmaisdel");
			strSql.Append(" where cmaid=@cmaid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmaarticle", DbType.Int32,4),
					new SQLiteParameter("@cmaauthor", DbType.Int32,4),
					new SQLiteParameter("@cmatitle", DbType.String),
					new SQLiteParameter("@cmacontent", DbType.String),
					new SQLiteParameter("@cmaaddtime", DbType.DateTime),
					new SQLiteParameter("@cmaisdel", DbType.Boolean),
					new SQLiteParameter("@cmaid", DbType.Int32,8)};
			parameters[0].Value = model.cmaarticle;
			parameters[1].Value = model.cmaauthor;
			parameters[2].Value = model.cmatitle;
			parameters[3].Value = model.cmacontent;
			parameters[4].Value = model.cmaaddtime;
			parameters[5].Value = model.cmaisdel;
			parameters[6].Value = model.cmaid;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int cmaid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogCommentArticle ");
			strSql.Append(" where cmaid=@cmaid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmaid", DbType.Int32,4)
			};
			parameters[0].Value = cmaid;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string cmaidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogCommentArticle ");
			strSql.Append(" where cmaid in ("+cmaidlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Blogs.Model.BlogCommentArticle GetModel(int cmaid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select cmaid,cmaarticle,cmaauthor,cmatitle,cmacontent,cmaaddtime,cmaisdel from BlogCommentArticle ");
			strSql.Append(" where cmaid=@cmaid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmaid", DbType.Int32,4)
			};
			parameters[0].Value = cmaid;

			Blogs.Model.BlogCommentArticle model=new Blogs.Model.BlogCommentArticle();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Blogs.Model.BlogCommentArticle DataRowToModel(DataRow row)
		{
			Blogs.Model.BlogCommentArticle model=new Blogs.Model.BlogCommentArticle();
			if (row != null)
			{
				if(row["cmaid"]!=null && row["cmaid"].ToString()!="")
				{
					model.cmaid=int.Parse(row["cmaid"].ToString());
				}
				if(row["cmaarticle"]!=null && row["cmaarticle"].ToString()!="")
				{
					model.cmaarticle=int.Parse(row["cmaarticle"].ToString());
				}
				if(row["cmaauthor"]!=null && row["cmaauthor"].ToString()!="")
				{
					model.cmaauthor=int.Parse(row["cmaauthor"].ToString());
				}
				if(row["cmatitle"]!=null)
				{
					model.cmatitle=row["cmatitle"].ToString();
				}
				if(row["cmacontent"]!=null)
				{
					model.cmacontent=row["cmacontent"].ToString();
				}
				if(row["cmaaddtime"]!=null && row["cmaaddtime"].ToString()!="")
				{
					model.cmaaddtime=DateTime.Parse(row["cmaaddtime"].ToString());
				}
				if(row["cmaisdel"]!=null && row["cmaisdel"].ToString()!="")
				{
					if((row["cmaisdel"].ToString()=="1")||(row["cmaisdel"].ToString().ToLower()=="true"))
					{
						model.cmaisdel=true;
					}
					else
					{
						model.cmaisdel=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select cmaid,cmaarticle,cmaauthor,cmatitle,cmacontent,cmaaddtime,cmaisdel ");
			strSql.Append(" FROM BlogCommentArticle ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM BlogCommentArticle ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.cmaid desc");
			}
			strSql.Append(")AS Row, T.*  from BlogCommentArticle T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "BlogCommentArticle";
			parameters[1].Value = "cmaid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

