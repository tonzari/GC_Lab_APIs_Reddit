#pragma checksum "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c215d43a1d15e5b494656d09551505d94a4e2fdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forecast), @"mvc.1.0.view", @"/Views/Home/Forecast.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\_ViewImports.cshtml"
using GC_Demo_APIs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\_ViewImports.cshtml"
using GC_Demo_APIs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c215d43a1d15e5b494656d09551505d94a4e2fdb", @"/Views/Home/Forecast.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff97fb80cff421aa95d2dff570a6bf493e86d940", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Forecast : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row mb-2\">\r\n");
#nullable restore
#line 4 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
             for (int i = 0; i < Model.properties.periods.Length; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6"">
                    <div class=""row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm  position-relative"">
                        <div class=""col p-4 d-flex flex-column position-static"">
                            <strong class=""d-inline-block mb-2 text-primary"">");
#nullable restore
#line 9 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
                                                                        Write(Model.properties.periods[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <h3 class=\"mb-0\"> ");
#nullable restore
#line 10 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
                                         Write(Model.properties.periods[i].temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"mb-1 text-muted\"> ");
#nullable restore
#line 11 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
                                                     Write(Model.properties.periods[i].startTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <p class=\"card-text mb-auto\"> ");
#nullable restore
#line 12 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
                                                     Write(Model.properties.periods[i].shortForecast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-auto d-none d-lg-block\">\r\n                            <img class=\"img-fluid mx-auto my-auto\" role=\"img\"");
            BeginWriteAttribute("src", " src=\"", 1010, "\"", 1049, 1);
#nullable restore
#line 15 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
WriteAttributeValue("", 1016, Model.properties.periods[i].icon, 1016, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"180\" height=\"180\"/>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\dude_dude\source\repos\GC_Demo_APIs\GC_Demo_APIs\Views\Home\Forecast.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
