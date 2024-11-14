<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/888575413/24.2.1%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
