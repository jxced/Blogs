/**  版本信息模板在安装目录下，可自行修改。
* BlogUser.cs
*
* 功 能： N/A
* 类 名： BlogUser
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/22 0:18:46   N/A    初版
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
		private int _islock=0;
		private bool _isdel= false;
		private DateTime _addtime;
		private DateTime _lastlogintime;
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
		public int islock
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
		public DateTime addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime lastlogintime
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

