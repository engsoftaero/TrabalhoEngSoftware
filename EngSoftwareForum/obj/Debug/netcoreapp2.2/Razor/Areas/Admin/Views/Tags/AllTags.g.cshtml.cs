#pragma checksum "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb741874775c10f26983ae32f95822d660374b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tags_AllTags), @"mvc.1.0.view", @"/Areas/Admin/Views/Tags/AllTags.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Tags/AllTags.cshtml", typeof(AspNetCore.Areas_Admin_Views_Tags_AllTags))]
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
#line 1 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\_ViewImports.cshtml"
using EngSoftwareForum;

#line default
#line hidden
#line 1 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
using EngSoftwareForum.Utility;

#line default
#line hidden
#line 2 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 3 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
using EngSoftwareForum.Models;

#line default
#line hidden
#line 4 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
using EngSoftwareForum.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb741874775c10f26983ae32f95822d660374b39", @"/Areas/Admin/Views/Tags/AllTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ce16048f9b7927b904861e09e38d7ba6f8d738", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Tags_AllTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(243, 205, true);
            WriteLiteral("\r\n\r\n<div class=\"border backgroudWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\"> Tags List</h2>\r\n        </div>\r\n        \r\n    </div>\r\n    <br />\r\n    <div>\r\n");
            EndContext();
#line 23 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
         if (Model.CountQuestions.Count() > 0)
        {
            var TagList = new List<string>();    
                
                

#line default
#line hidden
#line 27 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
                 foreach (var item in Model.CountQuestions)
                {
                    try
                    {
                        var thisQuestionTags = item.Tags.Split("#");

                        for (int i = 1; i < thisQuestionTags.Length; i++)
                        {
                            if (!TagList.Contains(thisQuestionTags[i]))
                            {
                                TagList.Add(thisQuestionTags[i]);
                            }
                        }
                    }
                    catch
                    {

                    }
                }

#line default
#line hidden
#line 45 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
                 

                        int j = TagList.Count;

                        TagList = TagList.OrderBy(o => o).ToList(); //ordena a lista de tags alfabeticamente

                        for (int i = 0; i < j; i++)
                        {

#line default
#line hidden
            BeginContext(1468, 90, true);
            WriteLiteral("                        <div class=\"btn-group\" role=\"group\">\r\n                            ");
            EndContext();
            BeginContext(1558, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb741874775c10f26983ae32f95822d660374b397481", async() => {
                BeginContext(1680, 93, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-tag\"></i>\r\n                               ");
                EndContext();
                BeginContext(1774, 10, false);
#line 56 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
                          Write(TagList[i]);

#line default
#line hidden
                EndContext();
                BeginContext(1784, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
                                                                                                                            WriteLiteral(TagList[i]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1818, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 59 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
                        }
        }
        else
        {

#line default
#line hidden
            BeginContext(1915, 44, true);
            WriteLiteral("            <p>No questions available.</p>\r\n");
            EndContext();
#line 64 "C:\Users\ronal\Downloads\Pessoal\ES\Trabalho\EngSoftwareForum\Areas\Admin\Views\Tags\AllTags.cshtml"
        }

#line default
#line hidden
            BeginContext(1970, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
