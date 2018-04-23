' Developer Express Code Central Example:
' How to create a custom theme for DXNavBar for WPF
' 
' This is an example of applying a custom theme to the NavBarControl. A demo theme
' is defined in CustomTheme.xaml. Its name is assigned to the NavBar's
' ThemeManager.ThemeName.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1454


Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.NavBar


Namespace DXNavBarCustomTheme

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ChangeView(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If navBar Is Nothing Then
				Return
			End If

			Dim view As String = TryCast((CType(e.Source, RadioButton)).Content, String)

			Select Case view
				Case "ExplorerBar"
					navBar.View = New ExplorerBarView()
				Case "NavigationPane"
					navBar.View = New NavigationPaneView()
				Case "SideBar"
					navBar.View = New SideBarView()
			End Select

		End Sub
	End Class
End Namespace
