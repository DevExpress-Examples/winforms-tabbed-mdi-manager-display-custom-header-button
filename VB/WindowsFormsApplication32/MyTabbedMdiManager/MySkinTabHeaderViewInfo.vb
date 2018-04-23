Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Buttons
Imports DevExpress.XtraTab.ViewInfo

Namespace CustomTabbedMdiManager
	Public Class MySkinTabHeaderViewInfo
		Inherits SkinTabHeaderViewInfo
		Public Sub New(ByVal viewInfo As BaseTabControlViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Protected Overrides Function CreateHeaderButtons() As TabButtonsPanel
			Return New MyTabButtonsPanel(ViewInfo)
		End Function

		Protected Overrides Function CalcButtonsSize(ByVal btns As TabButtons) As Size
			Dim buttonsSize As Size = MyBase.CalcButtonsSize(btns)
			If buttonsSize = Size.Empty AndAlso ViewInfo.AddActiveFilesButton Then
				buttonsSize = Buttons.CalcSize(GraphicsInfo.Graphics)
			End If

			Return buttonsSize
		End Function

		Public Shadows ReadOnly Property ViewInfo() As MySkinTabControlViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, MySkinTabControlViewInfo)
			End Get
		End Property
	End Class
End Namespace
