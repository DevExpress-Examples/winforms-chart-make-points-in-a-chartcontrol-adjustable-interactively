<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575161/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E294)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Chart for WinForms - How to Make Points in a Chart Control Interactively Adjustable 

This example demonstrates how to allow end-users to edit (move) series points data at runtime.

Handle the [ChartControl.ObjectHotTracked](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.ObjectHotTracked) event and call [ChartControl.XYDiagram.PointToDiagram](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.XYDiagram2D.PointToDiagram(System.Drawing.Point)) method to convert physical coordinates of the mouse to logical.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

## Documentation

* [Basic End-User Interaction](https://docs.devexpress.com/WindowsForms/2951/controls-and-libraries/chart-control/end-user-features/basic-end-user-interaction)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-chart-make-points-in-a-chartcontrol-adjustable-interactively&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-chart-make-points-in-a-chartcontrol-adjustable-interactively&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
