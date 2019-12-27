using DevExpress.XtraReports.Web.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dxExampleWebDocViewerChangeJobPrintName {
    public class ExportedDocumentService : IWebDocumentViewerExportResultUriGenerator {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ExportedDocumentService(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
        }
        private void SetDataToSession(string exportOperationId, byte[] bytes) {            
            _httpContextAccessor.HttpContext.Session.Set(exportOperationId, bytes);
        }
        public string CreateUri(string exportOperationId, ExportedDocument exportedDocument) {                        
            SetDataToSession(exportOperationId, exportedDocument.Bytes);
            return "PrintSampleReport?exportOperationId=" + exportOperationId;
        }       
    }
}
