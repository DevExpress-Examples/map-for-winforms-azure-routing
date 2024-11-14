## Map for WinForms - Use the Azure Maps Route Service to Calculate Routes for the Specified Geopoints

This example calculates a route for the specified geopoints.

> **NOTE:** You need a [key](https://learn.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#get-the-subscription-key-for-your-account) to use Azure Maps services in your application. Replace the `AzureKey` property value with your subscription key to connect to Azure Maps services.

Right-click on a map surface to specify an origin and destination. `ListBox` elements display geographical points (GeoPoint.Longitude and GeoPoint.Latitude) of the origin and destination positions. The “Calculate Route” button initiates the routing request. It obtains the waypoint information and passes it to the `CalculateRoute` method. The `ComboBoxEdit` and `CheckedListBox` editors specify route options (AzureRouteOptions.AvoidTypes and AzureRouteOptions.TravelMode properties).

The following image illustrates the result:

![Map](/images/mapImage.png)

## Files to Look At

* [Form1.cs](./CS/Form1.cs) 

## Documentation

* [Routing](https://docs.devexpress.com/WindowsForms/16713/controls-and-libraries/map-control/gis-data/routing?v=24.2)

## More Examples 

