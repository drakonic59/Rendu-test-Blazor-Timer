#pragma checksum "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c895d619eecf83a9939f5951d46044d15fabaec"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Timer</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor"
                   timerForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor"
                                             onFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.AddMarkupContent(10, "<label>Enter in seconds the time interval into each decrement (0 to 59):</label>&emsp;");
                __Blazor.tp.Pages.Timer.TypeInference.CreateInputNumber_0(__builder2, 11, 12, "number", 13, "interval", 14, 
#nullable restore
#line 11 "C:\Users\ilias\Documents\matters\tests unitaires\tp noté\rover_test\tp\Pages\Timer.razor"
                                                                                                                                                timerForm.interval

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => timerForm.interval = __value, timerForm.interval)), 16, () => timerForm.interval);
                __builder2.AddMarkupContent(17, "<br>\r\n\r\n    ");
                __builder2.AddMarkupContent(18, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.tp.Pages.Timer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
