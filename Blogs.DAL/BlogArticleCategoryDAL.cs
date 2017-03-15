using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace Blogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogArticleCategoryDAL
	/// </summary>
	public partial class BlogArticleCategoryDAL
	{
		public BlogArticleCategoryDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "BlogArticleCategory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogArticleCategory");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Blogs.Model.BlogArticleCategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogArticleCategory(");
			strSql.Append("author,categoryName,remark,status,isdel,addtime)");
			strSql.Append(" values (");
			strSql.Append("@author,@categoryName,@remark,@status,@isdel,@addtime)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@author", DbType.Int32,4),
					new SQLiteParameter("@categoryName", DbType.String),
					new SQLiteParameter("@remark", DbType.String),
					new SQLiteParameter("@status", DbType.Int32,4),
					new SQLiteParameter("@isdel", DbType.Boolean),
					new SQLiteParameter("@addtime", DbType.DateTime)};
			parameters[0].Value = model.author;
			parameters[1].Value = model.categoryName;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.status;
			parameters[4].Value = model.isdel;
			parameters[5].Value = model.addtime;

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
		public bool Update(Blogs.Model.BlogArticleCategory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogArticleCategory set ");
			strSql.Append("author=@author,");
			strSql.Append("categoryName=@categoryName,");
			strSql.Append("remark=@remark,");
			strSql.Append("status=@status,");
			strSql.Append("isdel=@isdel,");
			strSql.Append("addtime=@addtime");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@author", DbType.Int32,4),
					new SQLiteParameter("@categoryName", DbType.String),
					new SQLiteParameter("@remark", DbType.String),
					new SQLiteParameter("@status", DbType.Int32,4),
					new SQLiteParameter("@isdel", DbType.Boolean),
					new SQLiteParameter("@addtime", DbType.DateTime),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.author;
			parameters[1].Value = model.categoryName;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.status;
			parameters[4].Value = model.isdel;
			parameters[5].Value = model.addtime;
			parameters[6].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticleCategory ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticleCategory ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Blogs.Model.BlogArticleCategory GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,author,categoryName,remark,status,isdel,addtime from BlogArticleCategory ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			Blogs.Model.BlogArticleCategory model=new Blogs.Model.BlogArticleCategory();
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
		public Blogs.Model.BlogArticleCategory DataRowToModel(DataRow row)
		{
			Blogs.Model.BlogArticleCategory model=new Blogs.Model.BlogArticleCategory();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["author"]!=null && row["author"].ToString()!="")
				{
					model.author=int.Parse(row["author"].ToString());
				}
				if(row["categoryName"]!=null)
				{
					model.categoryName=row["categoryName"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["isdel"]!=null && row["isdel"].ToString()!="")
				{
					if((row["isdel"].ToString()=="1")||(row["isdel"].ToString().ToLower()=="true"))
					{
						model.isdel=true;
					}
					else
					{
						model.isdel=false;
					}
				}
				if(row["addtime"]!=null && row["addtime"].ToString()!="")
				{
					model.addtime=DateTime.Parse(row["addtime"].ToString());
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
			strSql.Append("select id,author,categoryName,remark,status,isdel,addtime ");
			strSql.Append(" FROM BlogArticleCategory ");
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
			strSql.Append("select count(1) FROM BlogArticleCategory ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from BlogArticleCategory T ");
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
			parameters[0].Value = "BlogArticleCategory";
			parameters[1].Value = "id";
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

