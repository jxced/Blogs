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
		private DateTime _cmpaddtime= Convert.ToDateTime(datetime("now"));
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

