#pragma checksum "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2447da3b26d5eb8a0f54a0ad6c729b76405844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Questions_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Questions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Questions/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Questions_Index))]
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
#line 1 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\_ViewImports.cshtml"
using EngSoftwareForum;

#line default
#line hidden
#line 1 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
using EngSoftwareForum.Utility;

#line default
#line hidden
#line 2 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 3 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
using EngSoftwareForum.Models;

#line default
#line hidden
#line 4 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
using EngSoftwareForum.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2447da3b26d5eb8a0f54a0ad6c729b76405844", @"/Areas/Admin/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ce16048f9b7927b904861e09e38d7ba6f8d738", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
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
#line 8 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(243, 165, true);
            WriteLiteral("\r\n\r\n<div class=\"border backgroudWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\"> Questions List</h2>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
         if (User.IsInRole(SD.ManagerUser) || User.IsInRole(SD.CustomerEndUser))
        {

#line default
#line hidden
            BeginContext(501, 60, true);
            WriteLiteral("            <div class=\"col-6 text-right\">\r\n                ");
            EndContext();
            BeginContext(561, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc2447da3b26d5eb8a0f54a0ad6c729b764058446463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(600, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 24 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(633, 35, true);
            WriteLiteral("    </div>\r\n    <br />\r\n    <div>\r\n");
            EndContext();
#line 28 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
         if (Model.CountQuestions.Count() > 0)
        {

#line default
#line hidden
            BeginContext(727, 152, true);
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(880, 43, false);
#line 33 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Questions.Title));

#line default
#line hidden
            EndContext();
            BeginContext(923, 322, true);
            WriteLiteral(@"
                    </th>
                    <th>
                        Votes
                    </th>
                    <th>
                        Answers
                    </th>
                    <th>
                        
                    </th>
                </tr>

               

");
            EndContext();
#line 48 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                  
                    var OrderedQuestions = Model.CountQuestions.OrderByDescending(c => c.Id).ToArray();
                

#line default
#line hidden
            BeginContext(1389, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 53 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                     foreach (var item in OrderedQuestions)
                    {

#line default
#line hidden
            BeginContext(1477, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1562, 32, false);
#line 57 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1688, 33, false);
#line 61 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                       Write(Html.DisplayFor(m => item.VoteGQ));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 61, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        \r\n");
            EndContext();
#line 65 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                            int vote_count=0;
                            for (int i=0; i < Model.RepliesCount.Count(); i++)
                            {
                                if(Model.RepliesCount.ElementAt(i).QuestionID == item.Id)
                                {
                                    vote_count++;
                                }
                            }
                        

#line default
#line hidden
            BeginContext(2210, 60, true);
            WriteLiteral("\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2271, 32, false);
#line 76 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                       Write(Html.DisplayFor(m => vote_count));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        \r\n\r\n                        <td>\r\n");
            EndContext();
#line 81 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                              
                                if ((item.UserID == Model.ApplicationUser.Name) || User.IsInRole(SD.ManagerUser))
                                {

#line default
#line hidden
            BeginContext(2576, 102, true);
            WriteLiteral("                                    <div class=\"alignright\">\r\n                                        ");
            EndContext();
            BeginContext(2678, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc2447da3b26d5eb8a0f54a0ad6c729b7640584412880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 85 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2733, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 87 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2887, 104, true);
            WriteLiteral("                                    <div class=\"alignright\">\r\n\r\n                                        ");
            EndContext();
            BeginContext(2991, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc2447da3b26d5eb8a0f54a0ad6c729b7640584415119", async() => {
                BeginContext(3074, 114, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-eye\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3192, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 96 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3304, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 100 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3381, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 102 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3439, 44, true);
            WriteLiteral("            <p>No questions available.</p>\r\n");
            EndContext();
#line 106 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\Questions\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3494, 20, true);
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
