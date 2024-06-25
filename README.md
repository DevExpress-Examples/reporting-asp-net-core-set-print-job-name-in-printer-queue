<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230440958/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848595)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
## Web Document Viewer - How to change the name of a print job in printer queue

In desktop applications, the name of a report in printer queue is taken from the [XtraReport.DisplayName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.DisplayName) property value. You can override it in the XtraReport.PrintingSystem.StartPrint event handler by specifying the DevExpress.XtraPrinting.PrintDocumentEventArgs.PrintDocument.DocumentName property.

When printing reports using Web Document Viewer, these settings won't take effect because web printing is PDF-based: see [specifics of web printing](https://docs.devexpress.com/XtraReports/5196/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/print-and-export/print-overview). 
Web Document Viewer takes the reporting print job name from the HTTP Handler Module that is used to communicate with the server. 
To change the reporting print job name, create a custom controller action with the required print job name and call it in a custom IWebDocumentViewerExportResultUriGenerator service's IWebDocumentViewerExportResultUriGenerator.CreateUri method.

See also:
[ASP.NET Core Reporting](https://docs.devexpress.com/XtraReports/119717/create-end-user-reporting-applications/web-reporting/aspnet-core-reporting)
[Register Services in the Document Viewer](https://docs.devexpress.com/XtraReports/400271/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/register-services-in-the-document-viewer)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-asp-net-core-set-print-job-name-in-printer-queue&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-asp-net-core-set-print-job-name-in-printer-queue&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
