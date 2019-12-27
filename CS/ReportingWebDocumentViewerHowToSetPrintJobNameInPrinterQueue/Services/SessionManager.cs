using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dxExampleWebDocViewerChangeJobPrintName {
    public class SessionManager {
        public IHttpContextAccessor _httpContextAccessor;
        public ISession _session;
        public SessionManager(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
        }
    }
}
