// Developer Express Code Central Example:
// How to create a custom theme for DXNavBar for WPF
// 
// This is an example of applying a custom theme to the NavBarControl. A demo theme
// is defined in CustomTheme.xaml. Its name is assigned to the NavBar's
// ThemeManager.ThemeName.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1454

using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.NavBar;


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
