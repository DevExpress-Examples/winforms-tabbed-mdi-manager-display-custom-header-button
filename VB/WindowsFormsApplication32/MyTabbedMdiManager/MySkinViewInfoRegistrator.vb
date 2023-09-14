Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo

Namespace CustomTabbedMdiManager

    Public Class MySkinViewInfoRegistrator
        Inherits SkinViewInfoRegistrator

        Public Sub New()
        End Sub

        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MySkinTabHeaderViewInfo(viewInfo)
        End Function

        Public Overrides Function CreateViewInfo(ByVal tabControl As IXtraTab) As BaseTabControlViewInfo
            Return New MySkinTabControlViewInfo(tabControl)
        End Function
    End Class
End Namespace
