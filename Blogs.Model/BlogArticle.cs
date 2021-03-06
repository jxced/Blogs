﻿using System;
namespace Blogs.Model
{
	/// <summary>
	/// BlogArticle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogArticle
	{
		public BlogArticle()
		{}
		#region Model
		private int _aid;
		private int _acate;
		private int _aauthor;
		private string _atitle;
		private string _acontent;
		private string _aimgsrc;
		private int? _aplnum=0;
		private bool _aallowpl= true;
		private bool _aistop= false;
		private string _atag;
		private int? _acick=0;
		private int? _astatu=2;
		private DateTime? _aaddtime;
		private DateTime? _aupdatetime;
		private bool _aisdel= false;
		private string _ahtmlsrc;
		/// <summary>
		/// 
		/// </summary>
		public int aid
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int acate
		{
			set{ _acate=value;}
			get{return _acate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int aauthor
		{
			set{ _aauthor=value;}
			get{return _aauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string atitle
		{
			set{ _atitle=value;}
			get{return _atitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string acontent
		{
			set{ _acontent=value;}
			get{return _acontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string aimgsrc
		{
			set{ _aimgsrc=value;}
			get{return _aimgsrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? aplnum
		{
			set{ _aplnum=value;}
			get{return _aplnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool aallowpl
		{
			set{ _aallowpl=value;}
			get{return _aallowpl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool aistop
		{
			set{ _aistop=value;}
			get{return _aistop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string atag
		{
			set{ _atag=value;}
			get{return _atag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? acick
		{
			set{ _acick=value;}
			get{return _acick;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? astatu
		{
			set{ _astatu=value;}
			get{return _astatu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? aaddtime
		{
			set{ _aaddtime=value;}
			get{return _aaddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? aupdatetime
		{
			set{ _aupdatetime=value;}
			get{return _aupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool aisdel
		{
			set{ _aisdel=value;}
			get{return _aisdel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ahtmlsrc
		{
			set{ _ahtmlsrc=value;}
			get{return _ahtmlsrc;}
		}
		#endregion Model

	}
}

