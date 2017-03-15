using System;
namespace Blogs.Model
{
	/// <summary>
	/// BlogUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlogUser
	{
		public BlogUser()
		{}
		#region Model
		private int _id;
		private string _loginname;
		private string _oginpwd;
		private string _cnname;
		private string _email;
		private bool _islock= false;
		private bool _isdel= false;
		private DateTime? _addtime;
		private DateTime? _lastlogintime;
		private string _lastloginip;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string loginname
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oginpwd
		{
			set{ _oginpwd=value;}
			get{return _oginpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cnname
		{
			set{ _cnname=value;}
			get{return _cnname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool islock
		{
			set{ _islock=value;}
			get{return _islock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isdel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? lastlogintime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lastloginip
		{
			set{ _lastloginip=value;}
			get{return _lastloginip;}
		}
		#endregion Model

	}
}

