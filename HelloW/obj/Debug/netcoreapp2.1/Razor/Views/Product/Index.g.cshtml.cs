#pragma checksum "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b68e332579c3f53760678cae87c261f8f42a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\_ViewImports.cshtml"
using HelloW;

#line default
#line hidden
#line 2 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\_ViewImports.cshtml"
using HelloW.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b68e332579c3f53760678cae87c261f8f42a18", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4048e6662a9df11e3d20e0ebb687c6c00f0bfa47", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
  
  ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(61, 54, true);
            WriteLiteral("<h2>This is Index Page</h2>\r\n<p class=\"alert-success\">");
            EndContext();
            BeginContext(116, 19, false);
#line 6 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
                    Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 114, true);
            WriteLiteral("</p>\r\n<ul>\r\n    <li>\r\n        <input type=\"checkbox\" id=\"check-all\" />\r\n        <span>Checkall</span>\r\n    </li>\r\n");
            EndContext();
#line 12 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(293, 73, true);
            WriteLiteral("        <li>\r\n            <span><input type=\"checkbox\" class=\"check-item\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 366, "\"", 391, 2);
            WriteAttributeValue("", 371, "check-id-", 371, 9, true);
#line 15 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
WriteAttributeValue("", 380, product.Id, 380, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 30, true);
            WriteLiteral(" /></span>\r\n            <span>");
            EndContext();
            BeginContext(423, 12, false);
#line 16 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
             Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(435, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(439, 13, false);
#line 16 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
                             Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(452, 23, true);
            WriteLiteral("</span>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 475, "\"", 510, 2);
            WriteAttributeValue("", 482, "/Product/Edit?id=", 482, 17, true);
#line 17 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
WriteAttributeValue("", 499, product.Id, 499, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 53, true);
            WriteLiteral(">Edit</a>\r\n            <a href=\"#\" class=\"btn-delete\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 564, "\"", 580, 1);
#line 18 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
WriteAttributeValue("", 569, product.Id, 569, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 28, true);
            WriteLiteral(">Delete</a>\r\n        </li>\r\n");
            EndContext();
#line 20 "C:\Users\YoLo\source\repos\HelloW\HelloW\Views\Product\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(616, 2129, true);
            WriteLiteral(@"</ul>  
<button id=""delete-all"">Delete All</button>
<script>
    var listBtnDelete = document.getElementsByClassName(""btn-delete"");
    for (var i = 0; i < listBtnDelete.length; i++) {
        listBtnDelete[i].onclick = function () {
            if (confirm(""Are you sure ?"")) {
                var currentDeleteButton = this;
                var deleteId = this.id;
                var xmlHttpRequest = new XMLHttpRequest();
                xmlHttpRequest.onreadystatechange = function () {
                    if (this.readyState === 4 && this.status === 200) {
                        alert(""Delete success ! "");
                        currentDeleteButton.parentElement.remove();
                    }
                }
                xmlHttpRequest.open(""DELETE"", ""/Product/Delete?id="" + deleteId, true);
                xmlHttpRequest.send();

            }
        };
    }
    var checkAll = document.getElementById(""check-all"");
    var listCheckbox = document.getElementsByClassName(""check-");
            WriteLiteral(@"item"");
    checkAll.onclick = function () {
        for (var i = 0; i < listCheckbox.length; i++) {
            listCheckbox[i].checked = this.checked;
        }
    }
    var deleteAll = document.getElementById(""delete-all"");
    deleteAll.onclick = function () {
        var checkedItems = document.querySelectorAll("".check-item:checked"");
        var deleteIds = new Array();
        for (var i = 0; i < checkedItems.length; i++) {
            deleteIds.push(checkedItems[i].id.replace(""check-id-"", """"));
        }
        console.log(deleteIds);
        if (deleteIds.length === 0) {
            alert(""Please choose at least 1 item."");
            return;
        }
        // goi ajax
        var xmlHttpRequest = new XMLHttpRequest();
        xmlHttpRequest.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                alert(""Delete success"");
            }
        }
        xmlHttpRequest.open(""DELETE"", ""/Product/DeleteMany?ids="" + de");
            WriteLiteral("leteIds, true);\r\n        xmlHttpRequest.send();\r\n    }\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591