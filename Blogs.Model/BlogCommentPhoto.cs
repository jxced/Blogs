/**  版本信息模板在安装目录下，可自行修改。
* BlogCommentPhoto.cs
*
* 功 能： N/A
* 类 名： BlogCommentPhoto
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/22 0:18:44   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Blogs.Model
{
	/// <summary>
	/// BlogCommentPhoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogCommentPhoto
	{
		public BlogCommentPhoto()
		{}
		#region Model
		private int _cmpid;
		private int _cmpauthor;
		private int _cmpphoto;
		private string _cmptitle;
		private string _cmpcontent;
		private DateTime _cmpaddtime;
		private bool _cmpisdel= false;
		/// <summary>
		/// 
		/// </summary>
		public int cmpid
		{
			set{ _cmpid=value;}
			get{return _cmpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cmpauthor
		{
			set{ _cmpauthor=value;}
			get{return _cmpauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cmpphoto
		{
			set{ _cmpphoto=value;}
			get{return _cmpphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmptitle
		{
			set{ _cmptitle=value;}
			get{return _cmptitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmpcontent
		{
			set{ _cmpcontent=value;}
			get{return _cmpcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime cmpaddtime
		{
			set{ _cmpaddtime=value;}
			get{return _cmpaddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool cmpisdel
		{
			set{ _cmpisdel=value;}
			get{return _cmpisdel;}
		}
		#endregion Model

	}
}

