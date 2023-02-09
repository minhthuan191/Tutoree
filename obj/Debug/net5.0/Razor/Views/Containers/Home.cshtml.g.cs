#pragma checksum "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92937c4517837bc259d3227c48526d4643b4844b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tutoree.Pages.Containers.Views_Containers_Home), @"mvc.1.0.view", @"/Views/Containers/Home.cshtml")]
namespace Tutoree.Pages.Containers
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
#line 1 "D:\MinhThuan\EXE2\Tutoree\Views\_ViewImports.cshtml"
using Tutoree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
using Tutoree.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92937c4517837bc259d3227c48526d4643b4844b", @"/Views/Containers/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9441edc1a4a11ea250642ef45967beca5ed2e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-span-12 space-y-2 lg:col-span-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
  
    this.ViewData["Title"] = Routers.Home.Title;
    var total = (int)this.ViewData["total"];
    double totalPrice = 0;
    var categories = (SelectList)this.ViewData["categories"];
    var min = (string)this.Context.Request.Query["min"];
    var max = (string)this.Context.Request.Query["max"];
    var name = (string)this.Context.Request.Query["name"];
    var categoryId = (string)this.Context.Request.Query["categoryId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        <!-- BEGIN: Side Menu -->\r\n        ");
#nullable restore
#line 16 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
   Write(await Html.PartialAsync("../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- END: Side Menu -->
        <!-- BEGIN: Content -->
        <div class=""content"">
            <!-- BEGIN: Top Bar -->
            <!-- END: Top Bar -->

            <div class=""grid grid-cols-12 gap-5 mt-5 pos intro-y"">
                <!-- BEGIN: Item List -->
                <div class=""col-span-12 intro-y lg:col-span-7"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92937c4517837bc259d3227c48526d4643b4844b5580", async() => {
                WriteLiteral("\r\n                        <div class=\"flex items-end space-x-2\">\r\n                            <div class=\"space-y-2\">\r\n                                <label>Name</label>\r\n                                ");
#nullable restore
#line 30 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextField.cshtml", new
                                {
                                Label = "Name",
                                Field = "name",
                                Type = "text",
                                Value = name
                                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>Min Price</label>\r\n                                ");
#nullable restore
#line 40 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextFieldNumber.cshtml", new
                                {
                                Label = "Min price",
                                Field = "min",
                                Step = "0.01",
                                Value = min
                                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>Max Price</label>\r\n                                ");
#nullable restore
#line 50 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextFieldNumber.cshtml", new
                                {
                                Label = "Max price",
                                Field = "max",
                                Step = "0.01",
                                Value = max
                                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>Category</label>\r\n                                ");
#nullable restore
#line 60 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/SelectList.cshtml", new
                                {
                                Label = "Max price",
                                Values = categories,
                                Value = categoryId,
                                Field = "categoryId"
                                }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""flex items-end"">
                                <button class=""mb-2 btn btn-primary"">
                                    <i data-feather=""search"" class=""w-5 h-5""></i>
                                </button>

                            </div>

                            ");
#nullable restore
#line 75 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                       Write(await Html.PartialAsync("../Components/Form/FormHidden.cshtml",
                            new { Name = "pageSize", Value = (string)this.Context.Request.Query["pageSize"] ?? "12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 77 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                       Write(await Html.PartialAsync("../Components/Form/FormHidden.cshtml",
                            new { Name = "pageIndex", Value = (string)this.Context.Request.Query["pageIndex"] ?? "0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"grid grid-cols-12 gap-5 pt-5 mt-5 border-t border-theme-5\" id=\"store\">\r\n                        \r\n                    </div>\r\n                    ");
#nullable restore
#line 85 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("../Components/Common/Pagination.cshtml",
                    new
                    {
                    PageIndex = (string)this.Context.Request.Query["pageIndex"] ?? "0",
                    PageSize =
                    (string)this.Context.Request.Query["pageSize"] ?? "12",
                    Total = total
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <!-- END: Item List -->\r\n                <!-- BEGIN: Ticket -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92937c4517837bc259d3227c48526d4643b4844b11988", async() => {
                WriteLiteral(@"


                    <div>
                        <div class=""bg-white rounded-r-md intro-y rounded-t-md "">
                            <div class=""p-2 "">
                                <div class=""justify-center pos__tabs nav nav-tabs"" role=""tablist"">
                                    <a id=""ticket-tab"" data-toggle=""tab"" data-target=""#ticket"" href=""javascript:;""
                                        class=""flex-1 py-2 font-semibold text-center rounded-md "" role=""tab""
                                        aria-controls=""ticket"" aria-selected=""false"">My Cart</a>
                                </div>
                            </div>
                        </div>


                        <div class=""p-3 bg-white intro-y "">
                            ");
#nullable restore
#line 112 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                       Write(await Html.PartialAsync("../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <label>Payment Method</label>
                            <div class=""flex flex-col mt-2 sm:flex-row"">
                                <div class=""mr-2 form-check"">
                                    <input id=""radio-switch-4"" class=""form-check-input"" type=""radio"" name=""payment""
                                        value=""0"" checked=""checked""> <label class=""form-check-label""
                                        for=""radio-switch-4"">Cash</label>
                                </div>
                                <div class=""mt-2 mr-2 form-check sm:mt-0"">
                                    <input id=""radio-switch-5"" class=""form-check-input"" type=""radio"" name=""payment""
                                        value=""1""> <label class=""form-check-label"" for=""radio-switch-5"">Credit
                                        Card</label>
                                </div>

                            </div>
                        </div>

                     ");
                WriteLiteral(@"   <div class=""mb-2 overflow-hidden tab-content"" id=""cart"">
                            <div
                                class=""flex items-center block p-3 transition duration-300 ease-in-out rounded-md cursor-pointer "">
                                <div class=""w-3/6 mr-1 truncate pos__ticket__item-name"">
                                    Total
                                </div>
                                <div class=""flex items-center w-1/6 space-x-2"">

                                </div>
                                <div class=""w-1/6 ml-auto font-medium"" id=""total"">$");
#nullable restore
#line 138 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                                                                              Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        ");
#nullable restore
#line 142 "D:\MinhThuan\EXE2\Tutoree\Views\Containers\Home.cshtml"
                   Write(await Html.PartialAsync("../Components/Form/FormBtn.cshtml", "Order Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!-- END: Ticket -->\r\n            </div>\r\n        </div>\r\n        <!-- END: Content -->\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/home.js\"></script>\r\n<script src=\"/js/pagination.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
