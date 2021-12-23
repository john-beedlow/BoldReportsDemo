#pragma checksum "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eccca2d20a963da754d0cf3fe114372ea47df94"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorReportingTools.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using BlazorReportingTools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Repos\BoldReportsDemo\BoldReportsDemo\_Imports.razor"
using BlazorReportingTools.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportViewer.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportViewer.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportViewer.razor"
using BlazorReportingTools.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReportViewer")]
    public partial class ReportViewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"report-viewer\" style=\"width: 100%;min-height:800px\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportViewer.razor"
       
    // ReportViewer options
    BoldReportViewerOptions viewerOptions = new BoldReportViewerOptions();


    // Used to render the Bold Report Viewer component in Blazor page.
    public async void RenderReportViewer()
    {
        viewerOptions.ReportName = "sales-order-detail";
        viewerOptions.ServiceURL = "/api/BoldReportsAPI";
        await JSRuntime.InvokeVoidAsync("BoldReports.RenderViewer", "report-viewer", viewerOptions);
    }

    // Initial rendering of Bold Report Viewer
    protected override void OnAfterRender(bool firstRender)
    {
        RenderReportViewer();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
