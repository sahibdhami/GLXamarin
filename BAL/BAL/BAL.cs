using System;
using System.Collections.ObjectModel;
using DAL;
using System.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model.IContent;
using System.Collections.Generic;
using System.Linq;
namespace BAL
{
	public class Service
	{
		public Service ()
		{
		}
		public static List<IContent> FetchMockContents(){
			List<IContent> obj = new List<IContent> ();
			obj.Add (new Contents (){ content="Mock Content 1"
			});
			obj.Add (new Contents (){ content="Mock Content 2"
			});
			obj.Add (new Contents (){ content="Mock Content 3"
			});
			obj.Add (new Contents (){ content="Mock Content 4"
			});
			obj.Add (new Contents (){ content="Mock Content 5"
			});
			obj.Add (new Contents (){ content="Mock Content 6"
			});
			obj.Add (new Contents (){ content="Mock Content 7"
			});
			obj.Add (new Contents (){ content="Mock Content 8"
			});
			obj.Add (new Contents (){ content="Mock Content 9"
			});
			obj.Add (new Contents (){ content="Mock Content 10"
			});
			obj.Add (new Contents (){ content="Mock Content 11"
			});
			obj.Add (new Contents (){ content="Mock Content 12"
			});
			obj.Add (new Contents (){ content="Mock Content 13"
			});
			obj.Add (new Contents (){ content="Mock Content 14"
			});
			obj.Add (new Contents (){ content="Mock Content 15"
			});
			obj.Add (new Contents (){ content="Mock Content 16"
			});
			return obj;
		}
		public static async Task<List<IContent>> FetchServiceJSONContents(){
			Console.WriteLine ("Start fetchServiceJSONContents");
			var jsonStr = await DAL.Service.FetchJsonData ();
			List<IContent> data =  
				JsonConvert.DeserializeObject<List<Contents>>(jsonStr).ToList<IContent>();
		
			//Collection<Contents> data =  searlizer.Deserialize<Collection<Contents>> (jsonStr);
			Console.WriteLine ("End fetchServiceJSONContents");
			return data;
		}
		public static List<IContent> FetchSQLiteData(){
			return DAL.Service.FetchSQLLiteData ();
		}

	}
}

