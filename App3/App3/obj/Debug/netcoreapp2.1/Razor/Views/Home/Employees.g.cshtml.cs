#pragma checksum "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e427283787903ce93d3ad3910aad5ea2ac99cd40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employees), @"mvc.1.0.view", @"/Views/Home/Employees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Employees.cshtml", typeof(AspNetCore.Views_Home_Employees))]
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
#line 1 "C:\Users\Acer\source\repos\App3\App3\Views\_ViewImports.cshtml"
using App3;

#line default
#line hidden
#line 2 "C:\Users\Acer\source\repos\App3\App3\Views\_ViewImports.cshtml"
using App3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e427283787903ce93d3ad3910aad5ea2ac99cd40", @"/Views/Home/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4ec52cbc070cf7a9a14b81c8bb4a87b8c9bd99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
            BeginContext(47, 131, true);
            WriteLiteral("\r\n<h2>Employees</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>EmpId</th>\r\n        <th>Emp Name</th>\r\n        <th> Salary</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
     foreach(var emp in ViewBag.EmployeeList) {

#line default
#line hidden
            BeginContext(227, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(258, 9, false);
#line 16 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
           Write(emp.EmpID);

#line default
#line hidden
            EndContext();
            BeginContext(267, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(291, 11, false);
#line 17 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
           Write(emp.EmpName);

#line default
#line hidden
            EndContext();
            BeginContext(302, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(326, 10, false);
#line 18 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
           Write(emp.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(336, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 20 "C:\Users\Acer\source\repos\App3\App3\Views\Home\Employees.cshtml"
    }

#line default
#line hidden
            BeginContext(365, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
