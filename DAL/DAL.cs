using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Model.IContent;
namespace DAL
{
	public class Service
	{
		public Service ()
		{

		}
		public static async Task<string> FetchJsonData(){
			HttpClient httpc = new HttpClient ();
				HttpResponseMessage message =
				await httpc.GetAsync ("https://api.mongolab.com/api/1/databases/cap-db/collections/content?apiKey=jIo-im2Z6wujTVB8dIFg6A27VZsp7nBq");
			return message.Content.ReadAsStringAsync ().Result;
		}

		public static List<IContent> FetchSQLLiteData(){
			SQLiteData.DB db = new SQLiteData.DB ();
			return db.SelectContents ();
		}

	}
}

