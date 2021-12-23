using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoldReports.Web.ReportViewer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;

namespace BlazorReportingTools.Data
{
    [Route("api/{controller}/{action}/{id?}")]    
    public class BoldReportsAPIController : ControllerBase, IReportController
    {
        // Report viewer requires a memory cache to store the information of consecutive client request and
        // have the rendered report viewer information in server.
        private IMemoryCache _cache;

        // IHostingEnvironment used with sample to get the application data from wwwroot.
        private IWebHostEnvironment _hostingEnvironment;

        public BoldReportsAPIController(IMemoryCache memoryCache, IWebHostEnvironment hostingEnvironment)
        {
            _cache = memoryCache;
            _hostingEnvironment = hostingEnvironment;
        }
        //Get action for getting resources from the report
        [ActionName("GetResource")]
        [AcceptVerbs("GET")]
        // Method will be called from Report Viewer client to get the image src for Image report item.
        public object GetResource(ReportResource resource)
        {
            return ReportHelper.GetResource(resource, this, _cache);
        }

        // Method will be called to initialize the report information to load the report with ReportHelper for processing.
        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            reportOption.ReportModel.ReportServerUrl = "http://10.20.3.22/ReportServer";
            reportOption.ReportModel.ReportPath = "/GetUsers";
            reportOption.ReportModel.ReportServerCredential = new System.Net.NetworkCredential("****", "****", "****");

            reportOption.ReportModel.DataSourceCredentials.Add(new BoldReports.Web.DataSourceCredentials("MESDB", "****", "****"));
        }

        // Method will be called when reported is loaded with internally to start to layout process with ReportHelper.
        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
        }

        [HttpPost]
        public object PostFormReportAction()
        {
            return ReportHelper.ProcessReport(null, this, _cache);
        }

        // Post action to process the report from server based json parameters and send the result back to the client.
        [HttpPost]
        public object PostReportAction([FromBody] Dictionary<string, object> jsonArray)
        {
            return ReportHelper.ProcessReport(jsonArray, this, this._cache);
        }
    }

}
