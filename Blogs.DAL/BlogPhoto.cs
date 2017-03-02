using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Blogs.DBUtility;//Please add references
namespace Blogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogPhoto
	/// </summary>
	public partial class BlogPhoto
	{
		public BlogPhoto()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("pid", "BlogPhoto"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BlogPhoto");
			strSql.Append(" where pid=@pid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pid", DbType.Int32,8)			};
			parameters[0].Value = pid;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Blogs.Model.BlogPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BlogPhoto(");
			strSql.Append("pid,pauthor,palbum,ptitle,premark,psrc,pstatu,paddtime,pisdel)");
			strSql.Append(" values (");
			strSql.Append("@pid,@pauthor,@palbum,@ptitle,@premark,@psrc,@pstatu,@paddtime,@pisdel)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pid", DbType.Int32,8),
					new SQLiteParameter("@pauthor", DbType.Int32,8),
					new SQLiteParameter("@palbum", DbType.Int32,8),
					new SQLiteParameter("@ptitle", DbType.String),
					new SQLiteParameter("@premark", DbType.String),
					new SQLiteParameter("@psrc", DbType.String),
					new SQLiteParameter("@pstatu", DbType.Int32,4),
					new SQLiteParameter("@paddtime", DbType.DateTime),
					new SQLiteParameter("@pisdel", DbType.bit,1)};
			parameters[0].Value = model.pid;
			parameters[1].Value = model.pauthor;
			parameters[2].Value = model.palbum;
			parameters[3].Value = model.ptitle;
			parameters[4].Value = model.premark;
			parameters[5].Value = model.psrc;
			parameters[6].Value = model.pstatu;
			parameters[7].Value = model.paddtime;
			parameters[8].Value = model.pisdel;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Blogs.Model.BlogPhoto model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BlogPhoto set ");
			strSql.Append("pauthor=@pauthor,");
			strSql.Append("palbum=@palbum,");
			strSql.Append("ptitle=@ptitle,");
			strSql.Append("premark=@premark,");
			strSql.Append("psrc=@psrc,");
			strSql.Append("pstatu=@pstatu,");
			strSql.Append("paddtime=@paddtime,");
			strSql.Append("pisdel=@pisdel");
			strSql.Append(" where pid=@pid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pauthor", DbType.Int32,8),
					new SQLiteParameter("@palbum", DbType.Int32,8),
					new SQLiteParameter("@ptitle", DbType.String),
					new SQLiteParameter("@premark", DbType.String),
					new SQLiteParameter("@psrc", DbType.String),
					new SQLiteParameter("@pstatu", DbType.Int32,4),
					new SQLiteParameter("@paddtime", DbType.DateTime),
					new SQLiteParameter("@pisdel", DbType.bit,1),
					new SQLiteParameter("@pid", DbType.Int32,8)};
			parameters[0].Value = model.pauthor;
			parameters[1].Value = model.palbum;
			parameters[2].Value = model.ptitle;
			parameters[3].Value = model.premark;
			parameters[4].Value = model.psrc;
			parameters[5].Value = model.pstatu;
			parameters[6].Value = model.paddtime;
			parameters[7].Value = model.pisdel;
			parameters[8].Value = model.pid;

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
		public bool Delete(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogPhoto ");
			strSql.Append(" where pid=@pid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pid", DbType.Int32,8)			};
			parameters[0].Value = pid;

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
		public bool DeleteList(string pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BlogPhoto ");
			strSql.Append(" where pid in ("+pidlist + ")  ");
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
		public Blogs.Model.BlogPhoto GetModel(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select pid,pauthor,palbum,ptitle,premark,psrc,pstatu,paddtime,pisdel from BlogPhoto ");
			strSql.Append(" where pid=@pid ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@pid", DbType.Int32,8)			};
			parameters[0].Value = pid;

			Blogs.Model.BlogPhoto model=new Blogs.Model.BlogPhoto();
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
		public Blogs.Model.BlogPhoto DataRowToModel(DataRow row)
		{
			Blogs.Model.BlogPhoto model=new Blogs.Model.BlogPhoto();
			if (row != null)
			{
				if(row["pid"]!=null && row["pid"].ToString()!="")
				{
					model.pid=int.Parse(row["pid"].ToString());
				}
				if(row["pauthor"]!=null && row["pauthor"].ToString()!="")
				{
					model.pauthor=int.Parse(row["pauthor"].ToString());
				}
				if(row["palbum"]!=null && row["palbum"].ToString()!="")
				{
					model.palbum=int.Parse(row["palbum"].ToString());
				}
				if(row["ptitle"]!=null)
				{
					model.ptitle=row["ptitle"].ToString();
				}
				if(row["premark"]!=null)
				{
					model.premark=row["premark"].ToString();
				}
				if(row["psrc"]!=null)
				{
					model.psrc=row["psrc"].ToString();
				}
				if(row["pstatu"]!=null && row["pstatu"].ToString()!="")
				{
					model.pstatu=int.Parse(row["pstatu"].ToString());
				}
				if(row["paddtime"]!=null && row["paddtime"].ToString()!="")
				{
					model.paddtime=DateTime.Parse(row["paddtime"].ToString());
				}
				if(row["pisdel"]!=null && row["pisdel"].ToString()!="")
				{
					if((row["pisdel"].ToString()=="1")||(row["pisdel"].ToString().ToLower()=="true"))
					{
						model.pisdel=true;
					}
					else
					{
						model.pisdel=false;
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
			strSql.Append("select pid,pauthor,palbum,ptitle,premark,psrc,pstatu,paddtime,pisdel ");
			strSql.Append(" FROM BlogPhoto ");
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
			strSql.Append("select count(1) FROM BlogPhoto ");
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
				strSql.Append("order by T.pid desc");
			}
			strSql.Append(")AS Row, T.*  from BlogPhoto T ");
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
			parameters[0].Value = "BlogPhoto";
			parameters[1].Value = "pid";
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

