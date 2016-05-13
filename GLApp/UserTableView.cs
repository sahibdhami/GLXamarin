using System;
using UIKit;
using System.Collections.ObjectModel;
using BAL;
using DAL;
using System.Json;
using System.Threading.Tasks;
using Model.IContent;
using System.Collections.Generic;
namespace GLApp
{
	public class UserTableView:UITableViewDataSource
	{
		List<IContent> contents;

		public UserTableView (List<IContent> contents)
		{
			this.contents = contents;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return contents.Count;
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			Console.WriteLine ("Start GetCell");
			UITableViewCell cell = tableView.DequeueReusableCell ("commoncell");
			if (cell == null) {
				cell = new UITableViewCell(UITableViewCellStyle.Default,"commoncell");	
			}
			cell.TextLabel.Text = contents [indexPath.Row].content;
			Console.WriteLine ("End GetCell");
			return cell;
		}
	}
}

