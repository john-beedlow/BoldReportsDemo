// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportDesigner.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportDesigner.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportDesigner.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\Repos\BoldReportsDemo\BoldReportsDemo\Pages\ReportDesigner.razor"
       
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
