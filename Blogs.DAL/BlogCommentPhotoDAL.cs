using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Blogs.DBUtility;//Please add references
namespace Blogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogCommentPhotoDAL
	/// </summary>
	public partial class BlogCommentPhotoDAL
	{
		public BlogCommentPhotoDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("cmpid", "BlogCommentPhoto"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int cmpid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogCommentPhoto");
			strSql.Append(" where cmpid=@cmpid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmpid", DbType.Int32,4)
			};
			parameters[0].Value = cmpid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Blogs.Model.BlogCommentPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogCommentPhoto(");
			strSql.Append("cmpauthor,cmpphoto,cmptitle,cmpcontent,cmpaddtime,cmpisdel)");
			strSql.Append(" values (");
			strSql.Append("@cmpauthor,@cmpphoto,@cmptitle,@cmpcontent,@cmpaddtime,@cmpisdel)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmpauthor", DbType.Int32,8),
					new SQLiteParameter("@cmpphoto", DbType.Int32,8),
					new SQLiteParameter("@cmptitle", DbType.String),
					new SQLiteParameter("@cmpcontent", DbType.String),
					new SQLiteParameter("@cmpaddtime", DbType.DateTime),
					new SQLiteParameter("@cmpisdel", DbType.Boolean)};
			parameters[0].Value = model.cmpauthor;
			parameters[1].Value = model.cmpphoto;
			parameters[2].Value = model.cmptitle;
			parameters[3].Value = model.cmpcontent;
			parameters[4].Value = model.cmpaddtime;
			parameters[5].Value = model.cmpisdel;

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
		public bool Update(Blogs.Model.BlogCommentPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogCommentPhoto set ");
			strSql.Append("cmpauthor=@cmpauthor,");
			strSql.Append("cmpphoto=@cmpphoto,");
			strSql.Append("cmptitle=@cmptitle,");
			strSql.Append("cmpcontent=@cmpcontent,");
			strSql.Append("cmpaddtime=@cmpaddtime,");
			strSql.Append("cmpisdel=@cmpisdel");
			strSql.Append(" where cmpid=@cmpid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmpauthor", DbType.Int32,8),
					new SQLiteParameter("@cmpphoto", DbType.Int32,8),
					new SQLiteParameter("@cmptitle", DbType.String),
					new SQLiteParameter("@cmpcontent", DbType.String),
					new SQLiteParameter("@cmpaddtime", DbType.DateTime),
					new SQLiteParameter("@cmpisdel", DbType.Boolean),
					new SQLiteParameter("@cmpid", DbType.Int32,8)};
			parameters[0].Value = model.cmpauthor;
			parameters[1].Value = model.cmpphoto;
			parameters[2].Value = model.cmptitle;
			parameters[3].Value = model.cmpcontent;
			parameters[4].Value = model.cmpaddtime;
			parameters[5].Value = model.cmpisdel;
			parameters[6].Value = model.cmpid;

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
		public bool Delete(int cmpid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogCommentPhoto ");
			strSql.Append(" where cmpid=@cmpid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmpid", DbType.Int32,4)
			};
			parameters[0].Value = cmpid;

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
		public bool DeleteList(string cmpidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogCommentPhoto ");
			strSql.Append(" where cmpid in ("+cmpidlist + ")  ");
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
		public Blogs.Model.BlogCommentPhoto GetModel(int cmpid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select cmpid,cmpauthor,cmpphoto,cmptitle,cmpcontent,cmpaddtime,cmpisdel from BlogCommentPhoto ");
			strSql.Append(" where cmpid=@cmpid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@cmpid", DbType.Int32,4)
			};
			parameters[0].Value = cmpid;

			Blogs.Model.BlogCommentPhoto model=new Blogs.Model.BlogCommentPhoto();
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
		public Blogs.Model.BlogCommentPhoto DataRowToModel(DataRow row)
		{
			Blogs.Model.BlogCommentPhoto model=new Blogs.Model.BlogCommentPhoto();
			if (row != null)
			{
				if(row["cmpid"]!=null && row["cmpid"].ToString()!="")
				{
					model.cmpid=int.Parse(row["cmpid"].ToString());
				}
				if(row["cmpauthor"]!=null && row["cmpauthor"].ToString()!="")
				{
					model.cmpauthor=int.Parse(row["cmpauthor"].ToString());
				}
				if(row["cmpphoto"]!=null && row["cmpphoto"].ToString()!="")
				{
					model.cmpphoto=int.Parse(row["cmpphoto"].ToString());
				}
				if(row["cmptitle"]!=null)
				{
					model.cmptitle=row["cmptitle"].ToString();
				}
				if(row["cmpcontent"]!=null)
				{
					model.cmpcontent=row["cmpcontent"].ToString();
				}
				if(row["cmpaddtime"]!=null && row["cmpaddtime"].ToString()!="")
				{
					model.cmpaddtime=DateTime.Parse(row["cmpaddtime"].ToString());
				}
				if(row["cmpisdel"]!=null && row["cmpisdel"].ToString()!="")
				{
					if((row["cmpisdel"].ToString()=="1")||(row["cmpisdel"].ToString().ToLower()=="true"))
					{
						model.cmpisdel=true;
					}
					else
					{
						model.cmpisdel=false;
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
			strSql.Append("select cmpid,cmpauthor,cmpphoto,cmptitle,cmpcontent,cmpaddtime,cmpisdel ");
			strSql.Append(" FROM BlogCommentPhoto ");
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
			strSql.Append("select count(1) FROM BlogCommentPhoto ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQLite.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.cmpid desc");
			}
			strSql.Append(")AS Row, T.*  from BlogCommentPhoto T ");
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
			parameters[0].Value = "BlogCommentPhoto";
			parameters[1].Value = "cmpid";
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

