Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTabbedMdi

Namespace CustomTabbedMdiManager
	Public Class MyTabbedMdiManager
		Inherits XtraTabbedMdiManager
		Private headerShowActiveFilesButton_Renamed As Boolean

		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Public Sub New()
		End Sub

		Protected Overrides Function GetView() As BaseViewInfoRegistrator
			Dim view As BaseViewInfoRegistrator = MyBase.GetView()
			Dim skinView As SkinViewInfoRegistrator = TryCast(view, SkinViewInfoRegistrator)
			If skinView Is Nothing Then
				Return view
			End If

			Return New MySkinViewInfoRegistrator()
		End Function

		Protected Overrides Sub CreateView()
			If ViewInfo IsNot Nothing Then
				RemoveHandler ViewInfo.ActiveFilesButtonClick, AddressOf OnActiveFilesButtonClick
			End If

			MyBase.CreateView()
			AddHandler ViewInfo.ActiveFilesButtonClick, AddressOf OnActiveFilesButtonClick
		End Sub

		Protected Overridable Function CreateActiveFilesPopupMenu() As DXPopupMenu
			Return New DXPopupMenu()
		End Function

		Protected Overridable Function CreateMenuItem(ByVal page As XtraMdiTabPage) As DXMenuItem
			Dim menuItem As New DXMenuItem()
			menuItem.Caption = page.Text
			menuItem.Image = GetMdiTabPageImage(page)
			menuItem.Tag = page.MdiChild

			Return menuItem
		End Function

		Protected Function GetMdiTabPageImage(ByVal page As XtraMdiTabPage) As Image
			If page.Image IsNot Nothing Then
				Return page.Image
			End If

			Return ImageCollection.GetImageListImage(page.TabControl.Images, page.ImageIndex)
		End Function

		Protected Overridable Sub OnActiveFilesButtonClick(ByVal sender As Object, ByVal e As ActiveFilesButtonClickEventArgs)
			Dim parentForm As Form = Me.MdiParent
			If parentForm Is Nothing Then
				Return
			End If

			Dim activeFilesPopupMenu As DXPopupMenu = CreateActiveFilesPopupMenu()
			For Each page As XtraMdiTabPage In Me.Pages
				If (Not page.PageVisible) OrElse (Not page.PageEnabled) Then
					Continue For
				End If

				Dim menuItem As DXMenuItem = CreateMenuItem(page)
				AddHandler menuItem.Click, AddressOf OnActiveFilesButtonMenuItemClick
				activeFilesPopupMenu.Items.Add(menuItem)
			Next page

			Dim xtraTabIntf As IXtraTab = TryCast(Me, IXtraTab)
			If xtraTabIntf Is Nothing Then
				Return
			End If

			Dim menuPos As New Point(e.ButtonInfo.Bounds.X, e.ButtonInfo.Bounds.Bottom)
			MenuManagerHelper.GetMenuManager(xtraTabIntf.LookAndFeel).ShowPopupMenu(activeFilesPopupMenu, parentForm, menuPos)
		End Sub

		Private Sub OnActiveFilesButtonMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim menuItem As DXMenuItem = CType(sender, DXMenuItem)
			Dim childForm As Form = TryCast(menuItem.Tag, Form)
			If childForm IsNot Nothing Then
				childForm.BringToFront()
			End If
		End Sub

		<DefaultValue(False)> _
		Public Property HeaderShowActiveFilesButton() As Boolean
			Get
				Return headerShowActiveFilesButton_Renamed
			End Get
			Set(ByVal value As Boolean)
				If headerShowActiveFilesButton_Renamed = value Then
					Return
				End If

				headerShowActiveFilesButton_Renamed = value
				If ViewInfo IsNot Nothing Then
					ViewInfo.AddActiveFilesButton = value
				End If
			End Set
		End Property

		<Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
		Public Shadows ReadOnly Property ViewInfo() As MySkinTabControlViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, MySkinTabControlViewInfo)
			End Get
		End Property
	End Class
End Namespace
