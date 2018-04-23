Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Wpf.NavBar


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
