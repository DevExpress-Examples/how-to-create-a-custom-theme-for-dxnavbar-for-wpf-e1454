using System.Windows;
using System.Windows.Controls;
using DevExpress.Wpf.NavBar;


namespace DXNavBarCustomTheme {

	public partial class Window1 : Window {
		public Window1() {
			InitializeComponent();
		}

		private void ChangeView(object sender, RoutedEventArgs e) {
			if(navBar == null)
				return;

			string view = ((RadioButton)e.Source).Content as string;

			switch(view) {
				case "ExplorerBar":
					navBar.View = new ExplorerBarView();
					break;
				case "NavigationPane":
					navBar.View = new NavigationPaneView();
					break;
				case "SideBar":
					navBar.View = new SideBarView();
					break;
			}

		}
	}
}
