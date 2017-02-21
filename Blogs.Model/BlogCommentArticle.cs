/**  版本信息模板在安装目录下，可自行修改。
* BlogCommentArticle.cs
*
* 功 能： N/A
* 类 名： BlogCommentArticle
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
	/// BlogCommentArticle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogCommentArticle
	{
		public BlogCommentArticle()
		{}
		#region Model
		private int _cmaid;
		private int _cmaarticle;
		private int _cmaauthor;
		private string _cmatitle;
		private string _cmacontent;
		private DateTime _cmaaddtime;
		private bool _cmaisdel= false;
		/// <summary>
		/// 
		/// </summary>
		public int cmaid
		{
			set{ _cmaid=value;}
			get{return _cmaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cmaarticle
		{
			set{ _cmaarticle=value;}
			get{return _cmaarticle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cmaauthor
		{
			set{ _cmaauthor=value;}
			get{return _cmaauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmatitle
		{
			set{ _cmatitle=value;}
			get{return _cmatitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmacontent
		{
			set{ _cmacontent=value;}
			get{return _cmacontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime cmaaddtime
		{
			set{ _cmaaddtime=value;}
			get{return _cmaaddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool cmaisdel
		{
			set{ _cmaisdel=value;}
			get{return _cmaisdel;}
		}
		#endregion Model

	}
}

