#pragma checksum "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c461e6764cded5d1c1cf7ee23ccabee44f6d983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\_ViewImports.cshtml"
using StringMatch;

#line default
#line hidden
#line 1 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
using StringMatch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c461e6764cded5d1c1cf7ee23ccabee44f6d983", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4bafc478adab48a0ef0db0cce5aff274b25143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StringMatchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 84, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section id=\"MainForm\">\r\n");
            EndContext();
#line 8 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
             using (Html.BeginForm("Index", "Home", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                

#line default
#line hidden
            BeginContext(294, 23, false);
#line 10 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(319, 237, true);
            WriteLiteral("                <h3>Enter a Text and SubText and click the Find Matches Button.</h3>\r\n                <h4>The character position of each match for the subtext within the text will be displayed in the output</h4>\r\n                <hr />\r\n");
            EndContext();
            BeginContext(575, 64, false);
#line 15 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(641, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(704, 69, false);
#line 17 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Text, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(773, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(845, 62, false);
#line 19 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
                   Write(Html.TextAreaFor(m => m.Text, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(907, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(934, 74, false);
#line 20 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Text, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(1079, 64, false);
#line 23 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1208, 72, false);
#line 25 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.SubText, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1352, 64, false);
#line 27 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.SubText, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1443, 77, false);
#line 28 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.SubText, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1637, 71, false);
#line 32 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Output, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1780, 64, false);
#line 34 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(m => m.Output, new { @class = "form-control", }));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 303, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Find Matches"" class=""btn btn-default"" />
                    </div>
                </div>
");
            EndContext();
#line 42 "c:\users\muralikrishnan\source\repos\StringMatch\StringMatch\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2162, 40, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StringMatchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
