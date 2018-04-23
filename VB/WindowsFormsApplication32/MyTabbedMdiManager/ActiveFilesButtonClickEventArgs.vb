Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab.Buttons

Namespace CustomTabbedMdiManager
	Public Class ActiveFilesButtonClickEventArgs
		Inherits EventArgs
		Private clickedButtonInfo As TabButtonInfo

		Public Sub New(ByVal button As TabButtonInfo)
			clickedButtonInfo = button
		End Sub

		Public ReadOnly Property ButtonInfo() As TabButtonInfo
			Get
				Return clickedButtonInfo
			End Get
		End Property
	End Class
End Namespace
