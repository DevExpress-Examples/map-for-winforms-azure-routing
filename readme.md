<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/888575413/24.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1263357)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
## WinForms Maps - Use the Azure Maps Route Service to Calculate Routes between GeoPoints on a Map Surface 

This example calculates a route based on two or more RouteWaypoint objects.

> **NOTE:**
> To incorporate this solution within your DevExpress-powered app, you need an Azure Maps service [key](https://learn.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#get-the-subscription-key-for-your-account). Replace the `AzureKey` property value with your subscription key to connect to Azure Maps.

### Implementation Details 

Right-click on a map surface to specify waypoints: origin, destination, and points in between. ListBox entries display geographical points (GeoPoint.Longitude and GeoPoint.Latitude). The “Calculate Route” button initiates the routing request by obtaining waypoint information and passing it to the CalculateRoute method. ComboBoxEdit and CheckedListBox editors specify route options (`AzureRouteOptions.AvoidTypes` and `AzureRouteOptions.TravelMode` properties).

Output:

![Map](/images/mapImage.png)

## Files to Look At

* [Form1.cs](./CS/Form1.cs) 

## Documentation

* [Routing](https://docs.devexpress.com/WindowsForms/16713/controls-and-libraries/map-control/gis-data/routing?v=24.2)

## More Examples 
- [WinForms Maps - Obtain Information about a Geographical Point Using the Microsoft Azure Maps Geocode Service](https://github.com/DevExpress-Examples/map-for-winforms-azure-geocoding)
- [WinForms Maps - Create a Custom Search Panel Using the Microsoft Azure Maps Search Service](https://github.com/DevExpress-Examples/map-for-winforms-azure-search)

## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-routing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
