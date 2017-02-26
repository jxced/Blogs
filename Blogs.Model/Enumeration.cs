/**  版本信息模板在安装目录下，可自行修改。
* Enumeration.cs
*
* 功 能： N/A
* 类 名： Enumeration
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
	/// Enumeration:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Enumeration
	{
		public Enumeration()
		{}
		#region Model
		private int _e_id;
		private string _e_sid;
		private string _e_cname;
		private string _e_type;
		private string _e_remark;
		private DateTime _e_addtime;
		private bool _e_isdel= false;
		/// <summary>
		/// 
		/// </summary>
		public int e_id
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string e_sid
		{
			set{ _e_sid=value;}
			get{return _e_sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string e_cname
		{
			set{ _e_cname=value;}
			get{return _e_cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string e_type
		{
			set{ _e_type=value;}
			get{return _e_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string e_remark
		{
			set{ _e_remark=value;}
			get{return _e_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime e_addtime
		{
			set{ _e_addtime=value;}
			get{return _e_addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool e_isdel
		{
			set{ _e_isdel=value;}
			get{return _e_isdel;}
		}
		#endregion Model

	}
}

