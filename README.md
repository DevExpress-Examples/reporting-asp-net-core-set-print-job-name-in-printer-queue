<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230440958/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848595)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for ASP.NET Core - Change Print Job Name in Printer Queue

In desktop applications, the name of the report in the printer queue is taken from the value of the [XtraReport.DisplayName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.DisplayName) property. You can override this in the `XtraReport.PrintingSystem.StartPrint` event handler using the [PrintDocumentEventArgs.PrintDocument](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintDocumentEventArgs.PrintDocument) property.

When you print reports using the Web Document Viewer, these settings do not apply because the Web printing is done via PDF.
The web browser extracts the print job name from the resource name specified in the URI.

To change the name of the report print job, do the following:

- Set the [UseSameTab](https://docs.devexpress.com/XtraReports/DevExpress.Blazor.Reporting.DxDocumentViewerExportSettings.UseSameTab) property to **false**.
- Create a custom controller action named the same as the desired job.
- Create a URL with the name of the required print job in the `CreateUri `method of the `ExportedDocumentService` custom service, which is a descendant of the [IWebDocumentViewerExportResultUriGenerator](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerExportResultUriGenerator) service.

![](Images/printtoprinterbyname.gif)
## Files to Review

- [HomeController.cs](CS/dxExampleWebDocViewerChangeJobPrintName/Controllers/HomeController.cs)
- [ExportedDocumentService.cs](CS/dxExampleWebDocViewerChangeJobPrintName/Services/ExportedDocumentService.cs)
- [Startup.cs](CS/dxExampleWebDocViewerChangeJobPrintName/Startup.cs)

## Documentation

- [ASP.NET Core Reporting](https://docs.devexpress.com/XtraReports/119717/create-end-user-reporting-applications/web-reporting/aspnet-core-reporting)
- [Register Services in the Document Viewer](https://docs.devexpress.com/XtraReports/400271/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/register-services-in-the-document-viewer)
- [Print and Export Without a Preview in ASP.NET Core Application](https://docs.devexpress.com/XtraReports/404502/web-reporting/common-features/printing)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-asp-net-core-set-print-job-name-in-printer-queue&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-asp-net-core-set-print-job-name-in-printer-queue&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
