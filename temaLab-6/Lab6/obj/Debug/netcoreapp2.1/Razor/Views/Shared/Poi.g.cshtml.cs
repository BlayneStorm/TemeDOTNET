#pragma checksum "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\Shared\Poi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134c81e650e8374b5005e62d75ddd3101758dbe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Poi), @"mvc.1.0.view", @"/Views/Shared/Poi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Poi.cshtml", typeof(AspNetCore.Views_Shared_Poi))]
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
#line 1 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\_ViewImports.cshtml"
using Lab6;

#line default
#line hidden
#line 2 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\_ViewImports.cshtml"
using Lab6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134c81e650e8374b5005e62d75ddd3101758dbe9", @"/Views/Shared/Poi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2a39831ae62eebb2a965acf8bb139eba59f31c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Poi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Poi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(27, 10, false);
#line 2 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\Shared\Poi.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(37, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 3 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\Shared\Poi.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(78, 14, false);
#line 4 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\Shared\Poi.cshtml"
Write(Model.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(92, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(104, 15, false);
#line 5 "D:\Facultate - Stuff\Anul III\DOTNET\Munteanu - Labs\DotNetLabs\Lab6\Lab6\Views\Shared\Poi.cshtml"
Write(Model.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(119, 5, true);
            WriteLiteral("</h2>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Poi> Html { get; private set; }
    }
}
#pragma warning restore 1591
