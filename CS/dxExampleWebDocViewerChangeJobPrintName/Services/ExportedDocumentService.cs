using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Http;

namespace dxExampleWebDocViewerChangeJobPrintName.Services
{
    public class ExportedDocumentService : IWebDocumentViewerExportResultUriGenerator
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ExportedDocumentService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        private void SetDataToSession(string exportOperationId, ExportedDocument exportedDocument)
        {
            _httpContextAccessor.HttpContext.Session.Set(exportOperationId, exportedDocument.Bytes);
            _httpContextAccessor.HttpContext.Session.SetString($"{exportOperationId}-disposition", exportedDocument.ContentDisposition);
        }
        public string CreateUri(string exportOperationId, ExportedDocument exportedDocument)
        {
            SetDataToSession(exportOperationId, exportedDocument);
            return $"/PrintSampleReport/{exportedDocument.FileName}?exportOperationId=" + exportOperationId;
        }
    }
}
