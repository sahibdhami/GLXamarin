using System;
using System.Collections.ObjectModel;
using System.Data;
using SQLite;
using Model.IContent;
namespace SQLiteData
{
	public class Content:IContent
	{
		public string content { get; set; }
	}
}

