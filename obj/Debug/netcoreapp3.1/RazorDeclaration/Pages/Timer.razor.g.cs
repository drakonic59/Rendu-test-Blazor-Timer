#pragma checksum "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c895d619eecf83a9939f5951d46044d15fabaec"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace tp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using tp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\_Imports.razor"
using tp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/timer")]
    public partial class Timer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor"
       
    private TimerForm timerForm = new TimerForm();

    private void onFormSubmit()
    {
        String where = "decrement/" + timerForm.getInterval();
        NavigationManager.NavigateTo(where);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591