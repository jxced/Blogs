﻿using System;
using System.Data;
using System.Collections.Generic;
//using Blogs.Common;
using Blogs.Model;
namespace Blogs.BLL
{
	/// <summary>
	/// BlogUserBLL
	/// </summary>
	public partial class BlogUserBLL
	{
		private readonly Blogs.DAL.BlogUserDAL dal=new Blogs.DAL.BlogUserDAL();
		public BlogUserBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Blogs.Model.BlogUser model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Blogs.Model.BlogUser model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		//public bool DeleteList(string idlist )
		//{
		//	return dal.DeleteList(Blogs.Common.PageValidate.SafeLongFilter(idlist,0) );
		//}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Blogs.Model.BlogUser GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public Blogs.Model.BlogUser GetModelByCache(int id)
		//{
			
		//	string CacheKey = "BlogUserModel-" + id;
		//	object objModel = Blogs.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(id);
		//			if (objModel != null)
		//			{
		//				int ModelCache = Blogs.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				Blogs.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (Blogs.Model.BlogUser)objModel;
		//}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Blogs.Model.BlogUser> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Blogs.Model.BlogUser> DataTableToList(DataTable dt)
		{
			List<Blogs.Model.BlogUser> modelList = new List<Blogs.Model.BlogUser>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Blogs.Model.BlogUser model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

