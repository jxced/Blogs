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
		private DateTime _paddtime= Convert.ToDateTime(datetime("now"));
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

