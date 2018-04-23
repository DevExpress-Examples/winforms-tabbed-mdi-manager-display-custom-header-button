Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTabbedMdi

Namespace WindowsFormsApplication32
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim xtraForm As New XtraForm()
			xtraForm.MdiParent = Me
			xtraForm.Text = "Form 1"
			xtraForm.Show()

			Dim xtraForm1 As New XtraForm()
			xtraForm1.MdiParent = Me
			xtraForm1.Text = "Form 2"
			xtraForm1.Show()
		End Sub

		Private Sub myTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As MdiTabPageEventArgs) Handles myTabbedMdiManager1.PageAdded
			Dim tabbedMdi As XtraTabbedMdiManager = CType(sender, XtraTabbedMdiManager)
			e.Page.ImageIndex = tabbedMdi.Pages.Count - 1
		End Sub
	End Class
End Namespace