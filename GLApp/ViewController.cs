using System;
using BAL;
using UIKit;
using System.Collections.ObjectModel;
using Model.IContent;
using System.Collections.Generic;

namespace GLApp
{
	public partial class ViewController : UIViewController
	{
		UITableView tableView;
		UILabel jsonLbl = new UILabel(new CoreGraphics.CGRect(20, 20, 150, 50));
		UILabel sqlLbl = new UILabel(new CoreGraphics.CGRect(250, 20, 100, 50));
		UIButton jsonBtn = new UIButton(UIButtonType.System);
		UIButton sqlBtn = new UIButton(UIButtonType.System);
		ViewModel viewmodel = new ViewModel();
		UIActivityIndicatorView activityIndicator = new UIActivityIndicatorView (UIActivityIndicatorViewStyle.Gray);
		public ViewController (IntPtr handle) : base (handle) 
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SetDisplayElements ();
		}

		protected void SetDisplayElements(){
			this.View.BackgroundColor = UIColor.LightGray;

			jsonLbl.Text = "Json Async Call";
			sqlLbl.Text = "Sql Sync Call";

			jsonBtn.Frame = new CoreGraphics.CGRect(25, 70, 100, 20);
			sqlBtn.Frame = new CoreGraphics.CGRect (250, 70, 100, 20);

			jsonBtn.SetTitle("Get Data", UIControlState.Normal);
			sqlBtn.SetTitle("Get Data", UIControlState.Normal);

			jsonBtn.AllEvents += async (object sender, EventArgs e) => {
				//Display animation before making json service call
				activityIndicator.Center = this.View.Center;
				activityIndicator.StartAnimating ();
				this.View.Add (activityIndicator);
				tableView.DataSource = new UserTableView(await viewmodel.FetchServiceJSONContents ());
				tableView.ReloadData();
				activityIndicator.StopAnimating();
			};
			sqlBtn.AllEvents += (object sender, EventArgs e) => {
				//Display animation before making SQL  call
				activityIndicator.Center = this.View.Center;
				this.View.Add (activityIndicator);
				activityIndicator.StartAnimating ();
				tableView.DataSource = new UserTableView(viewmodel.FetchDataFromSQLIte());
				tableView.ReloadData();	
				activityIndicator.StopAnimating();
			};

			tableView = new UITableView(new CoreGraphics.CGRect(0,100, View.Bounds.Width, View.Bounds.Height));
			viewmodel.contents = BAL.Service.FetchMockContents ();
			tableView.DataSource = new UserTableView(viewmodel.contents);
			this.View.AddSubviews (jsonLbl, jsonBtn, sqlLbl, sqlBtn, tableView);
		}
	}
}

