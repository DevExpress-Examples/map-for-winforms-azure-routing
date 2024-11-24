Imports System
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace AzureRouting

    Public Partial Class Form1
        Inherits Form

        Const azureKey As String = "your key"

        Private geoPoints As ObservableCollection(Of GeoPoint) = New ObservableCollection(Of GeoPoint)()

        Private itemData As MapItemStorage

        Private routeInfoLayer As InformationLayer

        Private azureRoute As AzureRouteDataProvider

        Public Sub New()
            InitializeComponent()
             ''' Cannot convert InvocationExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.mapControl.Layers.AddRange(
'''                 new DevExpress.XtraMap.LayerBase[] {
'''                     new DevExpress.XtraMap.ImageLayer() {
'''                         DataProvider = new DevExpress.XtraMap.AzureMapDataProvider() {
'''                             AzureKey = AzureRouting.Form1.azureKey,
'''                             Tileset = DevExpress.XtraMap.AzureTileset.Imagery,
'''                         },
'''                     },
'''                     new DevExpress.XtraMap.ImageLayer() {
'''                         DataProvider = new DevExpress.XtraMap.AzureMapDataProvider() {
'''                             AzureKey = AzureRouting.Form1.azureKey,
'''                             Tileset = DevExpress.XtraMap.AzureTileset.BaseHybridRoad,
'''                         },
'''                     },
'''                     this.routeInfoLayer = new DevExpress.XtraMap.InformationLayer() {
'''                         DataProvider = this.azureRoute = new DevExpress.XtraMap.AzureRouteDataProvider() {
'''                             AzureKey = AzureRouting.Form1.azureKey,
'''                         },
'''                     },
'''                     new DevExpress.XtraMap.VectorItemsLayer() {
'''                         Data = this.itemData = new DevExpress.XtraMap.MapItemStorage(),
'''                     }
'''                 }
'''             )
'''  DataProvider = azureRoute
            routeInfoLayer.ItemStyle.StrokeWidth = 2
            routeInfoLayer.ItemStyle.Stroke = Color.DeepSkyBlue
            AddHandler routeInfoLayer.Error, AddressOf RouteInfoLayer_Error
            waypointsListBoxControl.DataSource = geoPoints
            mapControl.Zoom(6)
            mapControl.SetCenterPoint(New GeoPoint(40.714627, -74.002863), False)
            mapControl.EnableRotation = False
        End Sub

        Private Sub RouteInfoLayer_Error(ByVal sender As Object, ByVal e As MapErrorEventArgs)
            Throw New NotImplementedException()
        End Sub

        Private Sub mapControl_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim mouseEventArgs As MouseEventArgs = CType(e, MouseEventArgs)
            If mouseEventArgs.Button = MouseButtons.Right Then
                Dim mousePoint As GeoPoint = TryCast(mapControl.ScreenPointToCoordPoint(mouseEventArgs.Location), GeoPoint)
                geoPoints.Add(mousePoint)
                itemData.Items.Add(New MapPushpin() With {.Location = mousePoint})
            End If
        End Sub

        Private Sub calculateRouteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If geoPoints.Count <= 1 Then
                MessageBox.Show("Specify at least two Waypoints to calculate a route.")
                Return
            End If

            azureRoute.CalculateRoute(geoPoints.[Select](Function(point) New RouteWaypoint("", point)).ToList(), New AzureRouteOptions() With {.TravelMode = GetTravelMode(), .AvoidTypes = GetAvoidTypes()})
            geoPoints.Clear()
            itemData.Items.Clear()
        End Sub

        Private Function GetTravelMode() As AzureTravelMode
            Return CType([Enum].Parse(GetType(AzureTravelMode), CStr(travelModeComboBox.SelectedItem)), AzureTravelMode)
        End Function

        Private Function GetAvoidTypes() As AzureRouteAvoidType
            Dim avoidTypes = AzureRouteAvoidType.None
            For Each item As String In avoidTypesCheckedListBox.CheckedItems
                Dim avoidType = CType([Enum].Parse(GetType(AzureRouteAvoidType), item), AzureRouteAvoidType)
                avoidTypes = avoidTypes Or avoidType
            Next

            Return avoidTypes
        End Function
    End Class
End Namespace
