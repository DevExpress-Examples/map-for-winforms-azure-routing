using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace AzureRouting {
    public partial class Form1 : Form {
        const string azureKey = "your key";
        ObservableCollection<GeoPoint> geoPoints = new ObservableCollection<GeoPoint>();
        MapItemStorage itemData;
        InformationLayer routeInfoLayer;
        AzureRouteDataProvider azureRoute;

        public Form1() {
            InitializeComponent();
            mapControl.Layers.AddRange(
                new LayerBase[] {
                    new ImageLayer() {
                        DataProvider = new AzureMapDataProvider() {
                            AzureKey = azureKey,
                            Tileset = AzureTileset.Imagery,
                        },
                    },
                    new ImageLayer() {
                        DataProvider = new AzureMapDataProvider() {
                            AzureKey = azureKey,
                            Tileset = AzureTileset.BaseHybridRoad,
                        },
                    },
                    routeInfoLayer = new InformationLayer() {
                        DataProvider = azureRoute = new AzureRouteDataProvider() {
                            AzureKey = azureKey,
                        },
                    },
                    new VectorItemsLayer() {
                        Data = itemData = new MapItemStorage(),
                    }
                }
            );
            routeInfoLayer.ItemStyle.StrokeWidth = 2;
            routeInfoLayer.ItemStyle.Stroke = Color.DeepSkyBlue;
            routeInfoLayer.Error += RouteInfoLayer_Error;
            waypointsListBoxControl.DataSource = geoPoints;
            mapControl.Zoom(6);
            mapControl.SetCenterPoint(new GeoPoint(40.714627, -74.002863), false);
            mapControl.EnableRotation = false;
        }
        private void RouteInfoLayer_Error(object sender, MapErrorEventArgs e) {
            throw new System.NotImplementedException();
        }
        private void mapControl_Click(object sender, System.EventArgs e) {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            if(mouseEventArgs.Button == MouseButtons.Right) {
                GeoPoint mousePoint = mapControl.ScreenPointToCoordPoint(mouseEventArgs.Location) as GeoPoint;
                geoPoints.Add(mousePoint);
                itemData.Items.Add(new MapPushpin() {
                    Location = mousePoint,
                });
            }
        }
        private void calculateRouteButton_Click(object sender, System.EventArgs e) {
            if (geoPoints.Count <= 1) {
                MessageBox.Show("Specify at least two Waypoints to calculate a route.");
                return;
            }
            azureRoute.CalculateRoute(geoPoints.Select(point => new RouteWaypoint("", point)).ToList(), new AzureRouteOptions() {
                TravelMode = GetTravelMode(),
                AvoidTypes = GetAvoidTypes()
            });
            geoPoints.Clear();
            itemData.Items.Clear();
        }
        AzureTravelMode GetTravelMode() {
            return (AzureTravelMode)Enum.Parse(typeof(AzureTravelMode), (string)travelModeComboBox.SelectedItem);
        }
        AzureRouteAvoidType GetAvoidTypes() {
            var avoidTypes = AzureRouteAvoidType.None;
            foreach (string item in avoidTypesCheckedListBox.CheckedItems) {
                var avoidType = (AzureRouteAvoidType)Enum.Parse(typeof(AzureRouteAvoidType), item);
                avoidTypes |= avoidType;
            }
            return avoidTypes;
        }
    }
}
