using System;
using UIKit;
using System.Collections.Generic;
using Model.IContent;
using System.Threading.Tasks;
namespace GLApp
{
	public class ViewModel
	{
		public List<IContent> contents;
		public ViewModel ()
		{
			contents = new List<IContent>();
		}
		public List<IContent> FetchMockUpData(){
			contents = BAL.Service.FetchMockContents ();
			return contents;
		}
		public async  Task<List<IContent>> FetchServiceJSONContents(){
			contents =  await BAL.Service.FetchServiceJSONContents ();
			return contents;
		}
		public List<IContent> FetchDataFromSQLIte(){
			contents = BAL.Service.FetchSQLiteData ();
			return contents;
		}
	}
}

