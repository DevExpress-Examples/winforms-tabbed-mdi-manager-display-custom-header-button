Imports CustomTabbedMdiManager

Namespace WindowsFormsApplication32

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.myTabbedMdiManager2 = New CustomTabbedMdiManager.MyTabbedMdiManager(Me.components)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myTabbedMdiManager2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("bo_employee", "image://svgimages/business objects/bo_employee.svg")
            Me.svgImageCollection1.Add("bo_department", "image://svgimages/business objects/bo_department.svg")
            ' 
            ' myTabbedMdiManager2
            ' 
            Me.myTabbedMdiManager2.Images = Me.svgImageCollection1
            Me.myTabbedMdiManager2.MdiParent = Me
            AddHandler Me.myTabbedMdiManager2.PageAdded, New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(AddressOf Me.myTabbedMdiManager_PageAdded)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1002, 744)
            Me.IsMdiContainer = True
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myTabbedMdiManager2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private myTabbedMdiManager2 As CustomTabbedMdiManager.MyTabbedMdiManager

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
