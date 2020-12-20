#pragma checksum "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "962237ab3f3cd29a7efb3d43de3ec9aa6934d3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\_ViewImports.cshtml"
using WebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\_ViewImports.cshtml"
using WebAPI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"962237ab3f3cd29a7efb3d43de3ec9aa6934d3ea", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39cbca23f583d5c71bac1ab268ea68a4c5e4e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAPI.ViewModels.Common.PagedResultBase>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "962237ab3f3cd29a7efb3d43de3ec9aa6934d3ea3348", async() => {
                WriteLiteral(@"
    <style>
        .pagination{
            float:left;
            color:blue;
            background-color:#ffffff;
            
       }
            .pagination li {
                display: inline-block;
                border-style: groove;
                font-style: oblique;
                font-size: 16px;
                color:blue;
            }

        



    </style>

");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
  
    //pageIndex=?&keyword=?
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 57 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 1393, "\"", 1432, 1);
#nullable restore
#line 60 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1400, urlTemplate.Replace("{0}", "1"), 1400, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1534, "\"", 1600, 1);
#nullable restore
#line 63 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1541, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1541, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 65 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 71 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 73 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2039, "\"", 2066, 2);
            WriteAttributeValue("", 2047, "Trang", 2047, 5, true);
#nullable restore
#line 76 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 2052, i.ToString(), 2053, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2067, "\"", 2115, 1);
#nullable restore
#line 76 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2074, urlTemplate.Replace("{0}", i.ToString()), 2074, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 77 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2285, "\"", 2320, 1);
#nullable restore
#line 82 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2293, Model.PageCount.ToString(), 2293, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2321, "\"", 2387, 1);
#nullable restore
#line 82 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2328, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 2328, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2489, "\"", 2551, 1);
#nullable restore
#line 85 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2496, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2496, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 87 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 89 "C:\Users\Truong08\Desktop\New folder\WebAPI\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAPI.ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591