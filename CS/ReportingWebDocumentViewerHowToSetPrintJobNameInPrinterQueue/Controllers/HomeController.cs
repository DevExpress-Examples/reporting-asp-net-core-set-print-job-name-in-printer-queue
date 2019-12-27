using DevExpress.XtraReports.Web.ClientControls;
using Microsoft.AspNetCore.Mvc;


namespace dxExampleWebDocViewerChangeJobPrintName.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Viewer() {
            return View();
        }
        [HttpGet]
        public IActionResult PrintSampleReport(string exportOperationId) {
            ExportedDocument exportedDocument = new ExportedDocument();
            byte[] expDocBytes;
            HttpContext.Session.TryGetValue(exportOperationId, out expDocBytes);
            exportedDocument.Bytes = expDocBytes;
            if (exportedDocument == null) {
                return new NotFoundResult();
            }
            var fileResult = File(exportedDocument.Bytes, "application/pdf");
            if (exportedDocument.ContentDisposition != System.Net.Mime.DispositionTypeNames.Inline) {
                fileResult.FileDownloadName = exportedDocument.FileName;
            }
            HttpContext.Session.Set(exportOperationId, new byte[0]);
            return fileResult;
        }
    }
}
