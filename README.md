<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230440958/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848595)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## Web Document Viewer - How to change the name of a print job in printer queue

In desktop applications, the name of a report in printer queue is taken from the [XtraReport.DisplayName](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.DisplayName) property value. You can override it in the XtraReport.PrintingSystem.StartPrint event handler by specifying the DevExpress.XtraPrinting.PrintDocumentEventArgs.PrintDocument.DocumentName property.

When printing reports using Web Document Viewer, these settings won't take effect because web printing is PDF-based: see [specifics of web printing](https://docs.devexpress.com/XtraReports/5196/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/print-and-export/print-overview).
Web Browser retrieves the name of the print job from the resource name specified in the URI.

To change the name of the report print job, you should do the following:
- set the [UseSameTab](https://docs.devexpress.com/XtraReports/DevExpress.Blazor.Reporting.DxDocumentViewerExportSettings.UseSameTab) property to **false**;
- create a custom controller action with a name identical to the name of the required print job;
- in the CreateUri method of the ExportedDocumentService custom service, which is a descendant of the [IWebDocumentViewerExportResultUriGenerator](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerExportResultUriGenerator) service, create a URL that includes the name of the required print job.

See also:
[ASP.NET Core Reporting](https://docs.devexpress.com/XtraReports/119717/create-end-user-reporting-applications/web-reporting/aspnet-core-reporting)
[Register Services in the Document Viewer](https://docs.devexpress.com/XtraReports/400271/create-end-user-reporting-applications/web-reporting/asp-net-core-reporting/document-viewer/api-and-customization/register-services-in-the-document-viewer)
