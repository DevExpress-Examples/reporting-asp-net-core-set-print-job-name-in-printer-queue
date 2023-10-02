using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System;

namespace dxExampleWebDocViewerChangeJobPrintName.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }


        public IActionResult Viewer(
            [FromServices] IWebDocumentViewerClientSideModelGenerator viewerModelGenerator,
            [FromQuery] string reportName)
        {
            reportName = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var viewerModel = viewerModelGenerator.GetModel(reportName, CustomWebDocumentViewerController.DefaultUri);
            viewerModel.ExportSettings.UseSameTab = false;
            return View(viewerModel);
        }

        [HttpGet]
        [HttpPost]
        [Route("PrintSampleReport/{filename}/{exportOperationId?}")]
        public IActionResult PrintSampleReport(string filename, string exportOperationId)
        {
            ExportedDocument exportedDocument = new ExportedDocument();
            HttpContext.Session.TryGetValue(exportOperationId, out byte[] expDocBytes);
            exportedDocument.Bytes = expDocBytes;
            exportedDocument.ContentDisposition = HttpContext.Session.GetString($"{exportOperationId}-disposition");
            if (exportedDocument == null)
            {
                return new NotFoundResult();
            }
            var fileResult = File(exportedDocument.Bytes, "application/pdf");
            if (exportedDocument.ContentDisposition != System.Net.Mime.DispositionTypeNames.Inline)
            {
                fileResult.FileDownloadName = filename;
                Response.Headers[HeaderNames.AccessControlExposeHeaders] = HeaderNames.ContentDisposition;
            }
            HttpContext.Session.Set(exportOperationId, Array.Empty<byte>());
            return fileResult;
        }
    }
}
