#pragma checksum "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "48c4f256db3605b95d0a09274cd7ea625c52a5cd16c1428e8b1d524d2ab9bedf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\_ViewImports.cshtml"
using SessionState_C6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\_ViewImports.cshtml"
using SessionState_C6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48c4f256db3605b95d0a09274cd7ea625c52a5cd16c1428e8b1d524d2ab9bedf", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ba5dd58edfbddd824c8f0efec985fa3b8066ddfd1e3a19823476aa30916bbf7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SessionState_C6.Models.ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\Shared\Error.cshtml"
 if (Model?.RequestId != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>Request ID: <code>");
#nullable restore
#line 13 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\Shared\Error.cshtml"
                         Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></h3>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\ACER\Desktop\Sixth Sem (Lokesh)\dotnet\Lab_Works(Lokesh)\SessionState_C6\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SessionState_C6.Models.ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
