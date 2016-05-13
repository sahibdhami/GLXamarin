using System;
using System.Data;
using SQLite;
using System.Collections.Generic;
using Model.IContent;
using System.Linq;
namespace SQLiteData
{
	public class DB
	{
		SQLiteConnection conn;

		public DB ()
		{
			//For deleting the data
			//DeleteContent (); 

			//Uncomment following line once to load data, 
			//next time onward it has to commented again to avoid duplicate insertion.
			//InsertContent ();
		}

		public void InsertContent(){
			using (conn = new SQLiteConnection (@"/Users/RSD/Projects/goodluck/SQLiteData/myDB.db3")) {
				conn.CreateTable<Content>();

				//Insert few rows for testing in the DB
				conn.Insert(new Content (){ 
					content="SQLite Content 1"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 2"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 3"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 4"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 5"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 6"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 7"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 8"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 9"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 10"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 11"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 12"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 13"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 14"
				});
				conn.Insert(new Content (){ 
					content="SQLite Content 15"
				});
				conn.Close ();
			}
		}
		public List<IContent> SelectContents(){
			using (conn = new SQLiteConnection (@"/Users/RSD/Projects/goodluck/SQLiteData/myDB.db3")) {
				
				List<IContent> sqlData = conn.Query<Content> ("select * from Content").ToList<IContent> ();
				Console.WriteLine( sqlData);
				conn.Close ();
				return sqlData;
			}
		}

		public void DeleteContent(){
			using (conn = new SQLiteConnection (@"/Users/RSD/Projects/goodluck/SQLiteData/myDB.db3")) {
				conn.DeleteAll<Content> ();
				conn.Close ();
			}
		}
	}
}

