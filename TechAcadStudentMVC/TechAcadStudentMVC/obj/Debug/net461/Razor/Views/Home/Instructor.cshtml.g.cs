#pragma checksum "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3657fb1b6250b1e7d205ae1c3ea81319eb558489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Instructor), @"mvc.1.0.view", @"/Views/Home/Instructor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Instructor.cshtml", typeof(AspNetCore.Views_Home_Instructor))]
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
#line 1 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\_ViewImports.cshtml"
using TechAcadStudentMVC;

#line default
#line hidden
#line 2 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\_ViewImports.cshtml"
using TechAcadStudentMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3657fb1b6250b1e7d205ae1c3ea81319eb558489", @"/Views/Home/Instructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6958491077b8ebd6bd331b778c2dc8d7b0888d77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Instructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechAcadStudentMVC.Models.Instructor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml"
  
    ViewData["Title"] = "Instructor";

#line default
#line hidden
            BeginContext(91, 67, true);
            WriteLiteral("\r\n<h2>Instructor</h2>\r\n\r\n<h5>\r\n    Details for Instructor with ID: ");
            EndContext();
            BeginContext(159, 10, false);
#line 9 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml"
                               Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(169, 101, true);
            WriteLiteral("\r\n</h5>\r\n\r\n<p>\r\n    Further details about the Instructor:\r\n</p>\r\n<ul>\r\n    <li>\r\n        Another ID: ");
            EndContext();
            BeginContext(271, 8, false);
#line 17 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        First Name: ");
            EndContext();
            BeginContext(323, 15, false);
#line 20 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(338, 42, true);
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        Last Name: ");
            EndContext();
            BeginContext(381, 14, false);
#line 23 "C:\Users\adamo\source\repos\TechAcadStudentMVC\TechAcadStudentMVC\Views\Home\Instructor.cshtml"
              Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(395, 22, true);
            WriteLiteral("\r\n    </li>\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechAcadStudentMVC.Models.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
