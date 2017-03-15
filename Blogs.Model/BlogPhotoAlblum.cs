using System;
namespace Blogs.Model
{
	/// <summary>
	/// BlogPhotoAlblum:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogPhotoAlblum
	{
		public BlogPhotoAlblum()
		{}
		#region Model
		private int _paid;
		private int _paauthor;
		private string _patitle;
		private string _paremark;
		private string _pacoversrc="no.jpg";
		private int _paphotonum=0;
		private int _pastatu=1;
		private DateTime _paaddtime;
		private bool _paisdel= false;
		/// <summary>
		/// 
		/// </summary>
		public int paid
		{
			set{ _paid=value;}
			get{return _paid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int paauthor
		{
			set{ _paauthor=value;}
			get{return _paauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string patitle
		{
			set{ _patitle=value;}
			get{return _patitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paremark
		{
			set{ _paremark=value;}
			get{return _paremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pacoversrc
		{
			set{ _pacoversrc=value;}
			get{return _pacoversrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int paphotonum
		{
			set{ _paphotonum=value;}
			get{return _paphotonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pastatu
		{
			set{ _pastatu=value;}
			get{return _pastatu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime paaddtime
		{
			set{ _paaddtime=value;}
			get{return _paaddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool paisdel
		{
			set{ _paisdel=value;}
			get{return _paisdel;}
		}
		#endregion Model

	}
}

