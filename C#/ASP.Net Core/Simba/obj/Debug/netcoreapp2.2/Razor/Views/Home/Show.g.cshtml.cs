#pragma checksum "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15bb2940c64e8c12f57fc31b68816530d3ea0634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\_ViewImports.cshtml"
using Simba;

#line default
#line hidden
#line 2 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\_ViewImports.cshtml"
using Simba.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bb2940c64e8c12f57fc31b68816530d3ea0634", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befdcfa15ec88b116e7e596c3e1bd8fb4872de59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Simba.Models.BankAccount>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 62, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(95, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15bb2940c64e8c12f57fc31b68816530d3ea06343346", async() => {
                BeginContext(101, 33, true);
                WriteLiteral("\r\n    <title>Simba Bank</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(143, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15bb2940c64e8c12f57fc31b68816530d3ea06344561", async() => {
                BeginContext(149, 209, true);
                WriteLiteral("\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n            <td>Name</td>\r\n            <td>Balance</td>\r\n            <td>Animal Type</td>\r\n            </tr>  \r\n        </thead>\r\n       <tr>\r\n           <td> ");
                EndContext();
                BeginContext(359, 10, false);
#line 17 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\Home\Show.cshtml"
           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(369, 23, true);
                WriteLiteral("</td>\r\n           <td> ");
                EndContext();
                BeginContext(393, 10, false);
#line 18 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\Home\Show.cshtml"
           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(403, 23, true);
                WriteLiteral("</td>\r\n           <td> ");
                EndContext();
                BeginContext(427, 14, false);
#line 19 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\Home\Show.cshtml"
           Write(Model.Currency);

#line default
#line hidden
                EndContext();
                BeginContext(441, 23, true);
                WriteLiteral("</td>\r\n           <td> ");
                EndContext();
                BeginContext(465, 16, false);
#line 20 "C:\greenfox\BPAndrea\C#\ASP.Net Core\Simba\Views\Home\Show.cshtml"
           Write(Model.AnimalType);

#line default
#line hidden
                EndContext();
                BeginContext(481, 39, true);
                WriteLiteral("</td>\r\n       </tr>\r\n    </table>\r\n  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(527, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Simba.Models.BankAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591