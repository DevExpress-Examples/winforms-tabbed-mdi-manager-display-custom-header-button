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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowsFormsApplication32.Form1))
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.myTabbedMdiManager1 = New CustomTabbedMdiManager.MyTabbedMdiManager(Me.components)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myTabbedMdiManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageCollection1.Images.SetKeyName(0, "cash.bmp")
            Me.imageCollection1.Images.SetKeyName(1, "clients.bmp")
            ' 
            ' myTabbedMdiManager1
            ' 
            Me.myTabbedMdiManager1.HeaderShowActiveFilesButton = True
            Me.myTabbedMdiManager1.Images = Me.imageCollection1
            Me.myTabbedMdiManager1.MdiParent = Me
            AddHandler Me.myTabbedMdiManager1.PageAdded, New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(AddressOf Me.myTabbedMdiManager1_PageAdded)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(501, 387)
            Me.IsMdiContainer = True
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myTabbedMdiManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private myTabbedMdiManager1 As CustomTabbedMdiManager.MyTabbedMdiManager

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
