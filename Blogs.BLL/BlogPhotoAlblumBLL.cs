using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Blogs.Model;
namespace Blogs.BLL
{
	/// <summary>
	/// BlogPhotoAlblumBLL
	/// </summary>
	public partial class BlogPhotoAlblumBLL
	{
		private readonly Blogs.DAL.BlogPhotoAlblumDAL dal=new Blogs.DAL.BlogPhotoAlblumDAL();
		public BlogPhotoAlblumBLL()
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
		public bool Exists(int paid)
		{
			return dal.Exists(paid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Blogs.Model.BlogPhotoAlblum model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Blogs.Model.BlogPhotoAlblum model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int paid)
		{
			
			return dal.Delete(paid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string paidlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(paidlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Blogs.Model.BlogPhotoAlblum GetModel(int paid)
		{
			
			return dal.GetModel(paid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Blogs.Model.BlogPhotoAlblum GetModelByCache(int paid)
		{
			
			string CacheKey = "BlogPhotoAlblumModel-" + paid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(paid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Blogs.Model.BlogPhotoAlblum)objModel;
		}

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
		public List<Blogs.Model.BlogPhotoAlblum> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Blogs.Model.BlogPhotoAlblum> DataTableToList(DataTable dt)
		{
			List<Blogs.Model.BlogPhotoAlblum> modelList = new List<Blogs.Model.BlogPhotoAlblum>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Blogs.Model.BlogPhotoAlblum model;
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

