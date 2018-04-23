Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Buttons
Imports DevExpress.XtraTab.ViewInfo

Namespace CustomTabbedMdiManager
	Public Class MyTabButtonsPanel
		Inherits TabButtonsPanel
		Public Sub New(ByVal tabViewInfo As BaseTabControlViewInfo)
			MyBase.New(tabViewInfo)
		End Sub

		Public Overrides Sub CreateButtons(ByVal buttons As TabButtons)
			If Me.keepButtons > 0 Then
				Return
			End If

			Me.Buttons.Clear()
			If TabViewInfo.AddActiveFilesButton Then
				Me.Buttons.Add(CreateButton(TabButtonType.User))
			End If
			If (buttons And TabButtons.Prev) <> 0 Then
				Me.Buttons.Add(CreateButton(TabButtonType.Prev))
			End If
			If (buttons And TabButtons.Next) <> 0 Then
				Me.Buttons.Add(CreateButton(TabButtonType.Next))
			End If
			If (buttons And TabButtons.Close) <> 0 Then
				Me.Buttons.Add(CreateButton(TabButtonType.Close))
			End If
		End Sub

		Protected Overrides Function CreateButton(ByVal button As TabButtonType) As TabButtonInfo
			If button = TabButtonType.User Then
				Dim predefine As ButtonPredefines = If(Orientation = TabOrientation.Horizontal, ButtonPredefines.Down, ButtonPredefines.Right)
				Dim tabBtn As New TabButtonInfo(New EditorButton(predefine), button)
				Return tabBtn
			End If

			Return MyBase.CreateButton(button)
		End Function

		Public Shadows ReadOnly Property TabViewInfo() As MySkinTabControlViewInfo
			Get
				Return TryCast(MyBase.TabViewInfo, MySkinTabControlViewInfo)
			End Get
		End Property
	End Class
End Namespace
