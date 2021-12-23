#pragma checksum "E:\Repos\BoldReports2\blazor-reporting-components\Pages\ReportDesigner.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f8c7c38995f9143792a690a1b9d664ff2eddd1"
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
#line 1 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using BlazorReportingTools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Repos\BoldReports2\blazor-reporting-components\_Imports.razor"
using BlazorReportingTools.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repos\BoldReports2\blazor-reporting-components\Pages\ReportDesigner.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Repos\BoldReports2\blazor-reporting-components\Pages\ReportDesigner.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Repos\BoldReports2\blazor-reporting-components\Pages\ReportDesigner.razor"
using BlazorReportingTools.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReportDesigner")]
    public partial class ReportDesigner : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"report-designer\" style=\"width: 100%;height: 950px\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\Repos\BoldReports2\blazor-reporting-components\Pages\ReportDesigner.razor"
       
    // ReportDesigner options
    BoldReportDesignerOptions designerOptions = new BoldReportDesignerOptions();

    // Used to render the Bold Report Designer component in Blazor page.
    public async void RenderReportDesigner()
    {
        designerOptions.ServiceURL = "/api/ReportDesigner";
        await JSRuntime.InvokeVoidAsync("BoldReports.RenderDesigner", "report-designer", designerOptions);
    }
    // Initial rendering of Bold Report Designer
    protected override void OnAfterRender(bool firstRender)
    {
        RenderReportDesigner();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591