/**  版本信息模板在安装目录下，可自行修改。
* BlogPhoto.cs
*
* 功 能： N/A
* 类 名： BlogPhoto
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/22 0:18:45   N/A    初版
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
	/// BlogPhoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogPhoto
	{
		public BlogPhoto()
		{}
		#region Model
		private int _pid;
		private int _pauthor;
		private int _palbum;
		private string _ptitle;
		private string _premark;
		private string _psrc;
		private int _pstatu;
		private DateTime _paddtime;
		private bool _pisdel= false;
		/// <summary>
		/// 
		/// </summary>
		public int pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pauthor
		{
			set{ _pauthor=value;}
			get{return _pauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int palbum
		{
			set{ _palbum=value;}
			get{return _palbum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ptitle
		{
			set{ _ptitle=value;}
			get{return _ptitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string premark
		{
			set{ _premark=value;}
			get{return _premark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string psrc
		{
			set{ _psrc=value;}
			get{return _psrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pstatu
		{
			set{ _pstatu=value;}
			get{return _pstatu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime paddtime
		{
			set{ _paddtime=value;}
			get{return _paddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool pisdel
		{
			set{ _pisdel=value;}
			get{return _pisdel;}
		}
		#endregion Model

	}
}

