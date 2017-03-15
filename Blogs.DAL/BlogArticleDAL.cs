using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Blogs.DBUtility;//Please add references
namespace Blogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogArticleDAL
	/// </summary>
	public partial class BlogArticleDAL
	{
		public BlogArticleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("aid", "BlogArticle"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int aid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogArticle");
			strSql.Append(" where aid=@aid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@aid", DbType.Int32,4)
			};
			parameters[0].Value = aid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Blogs.Model.BlogArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogArticle(");
			strSql.Append("acate,aauthor,atitle,acontent,aimgsrc,aplnum,aallowpl,aistop,atag,acick,astatu,aaddtime,aupdatetime,aisdel,ahtmlsrc)");
			strSql.Append(" values (");
			strSql.Append("@acate,@aauthor,@atitle,@acontent,@aimgsrc,@aplnum,@aallowpl,@aistop,@atag,@acick,@astatu,@aaddtime,@aupdatetime,@aisdel,@ahtmlsrc)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@acate", DbType.Int32,4),
					new SQLiteParameter("@aauthor", DbType.Int32,4),
					new SQLiteParameter("@atitle", DbType.String),
					new SQLiteParameter("@acontent", DbType.String),
					new SQLiteParameter("@aimgsrc", DbType.String),
					new SQLiteParameter("@aplnum", DbType.Int32,4),
					new SQLiteParameter("@aallowpl", DbType.Boolean),
					new SQLiteParameter("@aistop", DbType.Boolean),
					new SQLiteParameter("@atag", DbType.String),
					new SQLiteParameter("@acick", DbType.Int32,4),
					new SQLiteParameter("@astatu", DbType.Int32,4),
					new SQLiteParameter("@aaddtime", DbType.DateTime),
					new SQLiteParameter("@aupdatetime", DbType.DateTime),
					new SQLiteParameter("@aisdel", DbType.Boolean),
					new SQLiteParameter("@ahtmlsrc", DbType.String)};
			parameters[0].Value = model.acate;
			parameters[1].Value = model.aauthor;
			parameters[2].Value = model.atitle;
			parameters[3].Value = model.acontent;
			parameters[4].Value = model.aimgsrc;
			parameters[5].Value = model.aplnum;
			parameters[6].Value = model.aallowpl;
			parameters[7].Value = model.aistop;
			parameters[8].Value = model.atag;
			parameters[9].Value = model.acick;
			parameters[10].Value = model.astatu;
			parameters[11].Value = model.aaddtime;
			parameters[12].Value = model.aupdatetime;
			parameters[13].Value = model.aisdel;
			parameters[14].Value = model.ahtmlsrc;

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
		public bool Update(Blogs.Model.BlogArticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogArticle set ");
			strSql.Append("acate=@acate,");
			strSql.Append("aauthor=@aauthor,");
			strSql.Append("atitle=@atitle,");
			strSql.Append("acontent=@acontent,");
			strSql.Append("aimgsrc=@aimgsrc,");
			strSql.Append("aplnum=@aplnum,");
			strSql.Append("aallowpl=@aallowpl,");
			strSql.Append("aistop=@aistop,");
			strSql.Append("atag=@atag,");
			strSql.Append("acick=@acick,");
			strSql.Append("astatu=@astatu,");
			strSql.Append("aaddtime=@aaddtime,");
			strSql.Append("aupdatetime=@aupdatetime,");
			strSql.Append("aisdel=@aisdel,");
			strSql.Append("ahtmlsrc=@ahtmlsrc");
			strSql.Append(" where aid=@aid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@acate", DbType.Int32,4),
					new SQLiteParameter("@aauthor", DbType.Int32,4),
					new SQLiteParameter("@atitle", DbType.String),
					new SQLiteParameter("@acontent", DbType.String),
					new SQLiteParameter("@aimgsrc", DbType.String),
					new SQLiteParameter("@aplnum", DbType.Int32,4),
					new SQLiteParameter("@aallowpl", DbType.Boolean),
					new SQLiteParameter("@aistop", DbType.Boolean),
					new SQLiteParameter("@atag", DbType.String),
					new SQLiteParameter("@acick", DbType.Int32,4),
					new SQLiteParameter("@astatu", DbType.Int32,4),
					new SQLiteParameter("@aaddtime", DbType.DateTime),
					new SQLiteParameter("@aupdatetime", DbType.DateTime),
					new SQLiteParameter("@aisdel", DbType.Boolean),
					new SQLiteParameter("@ahtmlsrc", DbType.String),
					new SQLiteParameter("@aid", DbType.Int32,8)};
			parameters[0].Value = model.acate;
			parameters[1].Value = model.aauthor;
			parameters[2].Value = model.atitle;
			parameters[3].Value = model.acontent;
			parameters[4].Value = model.aimgsrc;
			parameters[5].Value = model.aplnum;
			parameters[6].Value = model.aallowpl;
			parameters[7].Value = model.aistop;
			parameters[8].Value = model.atag;
			parameters[9].Value = model.acick;
			parameters[10].Value = model.astatu;
			parameters[11].Value = model.aaddtime;
			parameters[12].Value = model.aupdatetime;
			parameters[13].Value = model.aisdel;
			parameters[14].Value = model.ahtmlsrc;
			parameters[15].Value = model.aid;

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
		public bool Delete(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticle ");
			strSql.Append(" where aid=@aid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@aid", DbType.Int32,4)
			};
			parameters[0].Value = aid;

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
		public bool DeleteList(string aidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogArticle ");
			strSql.Append(" where aid in ("+aidlist + ")  ");
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
		public Blogs.Model.BlogArticle GetModel(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select aid,acate,aauthor,atitle,acontent,aimgsrc,aplnum,aallowpl,aistop,atag,acick,astatu,aaddtime,aupdatetime,aisdel,ahtmlsrc from BlogArticle ");
			strSql.Append(" where aid=@aid");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@aid", DbType.Int32,4)
			};
			parameters[0].Value = aid;

			Blogs.Model.BlogArticle model=new Blogs.Model.BlogArticle();
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
		public Blogs.Model.BlogArticle DataRowToModel(DataRow row)
		{
			Blogs.Model.BlogArticle model=new Blogs.Model.BlogArticle();
			if (row != null)
			{
				if(row["aid"]!=null && row["aid"].ToString()!="")
				{
					model.aid=int.Parse(row["aid"].ToString());
				}
				if(row["acate"]!=null && row["acate"].ToString()!="")
				{
					model.acate=int.Parse(row["acate"].ToString());
				}
				if(row["aauthor"]!=null && row["aauthor"].ToString()!="")
				{
					model.aauthor=int.Parse(row["aauthor"].ToString());
				}
				if(row["atitle"]!=null)
				{
					model.atitle=row["atitle"].ToString();
				}
				if(row["acontent"]!=null)
				{
					model.acontent=row["acontent"].ToString();
				}
				if(row["aimgsrc"]!=null)
				{
					model.aimgsrc=row["aimgsrc"].ToString();
				}
				if(row["aplnum"]!=null && row["aplnum"].ToString()!="")
				{
					model.aplnum=int.Parse(row["aplnum"].ToString());
				}
				if(row["aallowpl"]!=null && row["aallowpl"].ToString()!="")
				{
					if((row["aallowpl"].ToString()=="1")||(row["aallowpl"].ToString().ToLower()=="true"))
					{
						model.aallowpl=true;
					}
					else
					{
						model.aallowpl=false;
					}
				}
				if(row["aistop"]!=null && row["aistop"].ToString()!="")
				{
					if((row["aistop"].ToString()=="1")||(row["aistop"].ToString().ToLower()=="true"))
					{
						model.aistop=true;
					}
					else
					{
						model.aistop=false;
					}
				}
				if(row["atag"]!=null)
				{
					model.atag=row["atag"].ToString();
				}
				if(row["acick"]!=null && row["acick"].ToString()!="")
				{
					model.acick=int.Parse(row["acick"].ToString());
				}
				if(row["astatu"]!=null && row["astatu"].ToString()!="")
				{
					model.astatu=int.Parse(row["astatu"].ToString());
				}
				if(row["aaddtime"]!=null && row["aaddtime"].ToString()!="")
				{
					model.aaddtime=DateTime.Parse(row["aaddtime"].ToString());
				}
				if(row["aupdatetime"]!=null && row["aupdatetime"].ToString()!="")
				{
					model.aupdatetime=DateTime.Parse(row["aupdatetime"].ToString());
				}
				if(row["aisdel"]!=null && row["aisdel"].ToString()!="")
				{
					if((row["aisdel"].ToString()=="1")||(row["aisdel"].ToString().ToLower()=="true"))
					{
						model.aisdel=true;
					}
					else
					{
						model.aisdel=false;
					}
				}
				if(row["ahtmlsrc"]!=null)
				{
					model.ahtmlsrc=row["ahtmlsrc"].ToString();
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
			strSql.Append("select aid,acate,aauthor,atitle,acontent,aimgsrc,aplnum,aallowpl,aistop,atag,acick,astatu,aaddtime,aupdatetime,aisdel,ahtmlsrc ");
			strSql.Append(" FROM BlogArticle ");
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
			strSql.Append("select count(1) FROM BlogArticle ");
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
				strSql.Append("order by T.aid desc");
			}
			strSql.Append(")AS Row, T.*  from BlogArticle T ");
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
			parameters[0].Value = "BlogArticle";
			parameters[1].Value = "aid";
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

