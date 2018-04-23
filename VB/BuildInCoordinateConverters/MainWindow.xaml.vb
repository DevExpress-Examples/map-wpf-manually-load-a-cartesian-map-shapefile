Imports System
Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace BuildInCoordinateConverters
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            map.ZoomToFitLayerItems(0.4)
        End Sub
    End Class

    Public Class MapData
        Public Property FileUri() As Uri
        Public Property CoordinateSystem() As SourceCoordinateSystem

        Public Overrides Function ToString() As String
            Return String.Format("MapData[FileUri = {0}, CoordinateSystem = {1}]", FileUri, CoordinateSystem)
        End Function
    End Class
End Namespace
