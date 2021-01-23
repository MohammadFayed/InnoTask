#pragma checksum "C:\Users\hp\source\repos\InnoTechApp\InnoTechApp\Pages\Courses\ClientCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439339de9860a0be536bc51ab25ad9c51c96c88e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InnoTechApp.Pages.Courses.Pages_Courses_ClientCourses), @"mvc.1.0.razor-page", @"/Pages/Courses/ClientCourses.cshtml")]
namespace InnoTechApp.Pages.Courses
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
#line 1 "C:\Users\hp\source\repos\InnoTechApp\InnoTechApp\Pages\_ViewImports.cshtml"
using InnoTechApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439339de9860a0be536bc51ab25ad9c51c96c88e", @"/Pages/Courses/ClientCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb5c8f9c9de572953e5551a9a50e4a3ea6e1193", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_ClientCourses : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\InnoTechApp\InnoTechApp\Pages\Courses\ClientCourses.cshtml"
  
    ViewData["title"] = "ClientCourses";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"text-center pt-3\">Client Courses</h3>\r\n\r\n<table id=\"courses\" class=\"table table-bordered table-striped\">\r\n    <thead>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Price</th>\r\n        <th>Description</th>\r\n    </tr>\r\n    </thead>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.10.23/datatables.min.css""/>

    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.10.23/datatables.min.js""></script>

    <script>
        $(function() {
            $.ajax(""/Api/Course"",
                    { method: ""get"" })
                .then(function (response) {
                    $('#courses').DataTable( {
                        data: response,
                        columns: [
                            { data: ""name"" },
                            { data: 'price' },
                            { data: 'description' }
                        ]
                    });
                });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Courses_ClientCourses> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Courses_ClientCourses> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Courses_ClientCourses>)PageContext?.ViewData;
        public Pages_Courses_ClientCourses Model => ViewData.Model;
    }
}
#pragma warning restore 1591