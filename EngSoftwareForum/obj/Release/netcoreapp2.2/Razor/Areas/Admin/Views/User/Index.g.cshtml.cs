#pragma checksum "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b808da81dfe79fb3635b04314e571c80cd9639a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Index))]
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
#line 2 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\_ViewImports.cshtml"
using EngSoftwareForum.Models;

#line default
#line hidden
#line 1 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
using EngSoftwareForum.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b808da81dfe79fb3635b04314e571c80cd9639a", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ce16048f9b7927b904861e09e38d7ba6f8d738", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aligncenter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/User_icon_BLACK-01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Lock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnLock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 175, true);
            WriteLiteral("\r\n<br /><br />\r\n<div class=\"border backgroudWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\"> Users List</h2>\r\n        </div>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
         if (User.IsInRole(SD.ManagerUser))
        {

#line default
#line hidden
            BeginContext(391, 60, true);
            WriteLiteral("            <div class=\"col-6 text-right\">\r\n                ");
            EndContext();
            BeginContext(451, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b808da81dfe79fb3635b04314e571c80cd9639a8354", async() => {
                BeginContext(524, 56, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; New User Registration");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(584, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(617, 37, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
            EndContext();
#line 26 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(698, 152, true);
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(851, 32, false);
#line 31 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(883, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(963, 33, false);
#line 34 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(996, 306, true);
            WriteLiteral(@"
                    </th>

                    <th>
                        Profile picture
                    </th>

                    <th>
                        Description
                    </th>


                    <th></th>
                    <th></th>
                </tr>
");
            EndContext();
#line 49 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1367, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1452, 31, false);
#line 53 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1575, 32, false);
#line 56 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 89, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td style=\"width:300px\">\r\n\r\n");
            EndContext();
#line 62 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                              
                                string user_pic1 = item.Id + ".png"; //pega a imagem do usuario que postou a resposta

                                string path1 = "wwwroot\\Images\\" + user_pic1;

                                string wanted_path1 = System.AppDomain.CurrentDomain.BaseDirectory;
                                var array1 = wanted_path1.Split(new string[] { "bin" }, // lista de separadores complexos
                                StringSplitOptions.RemoveEmptyEntries);

                                wanted_path1 = array1[0] + path1;
                            

#line default
#line hidden
            BeginContext(2329, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                             if (System.IO.File.Exists(wanted_path1))
                            {

#line default
#line hidden
            BeginContext(2433, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2465, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b808da81dfe79fb3635b04314e571c80cd9639a14702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2475, "~/Images/", 2475, 9, true);
#line 76 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2484, user_pic1, 2484, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2543, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 77 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2641, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2673, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b808da81dfe79fb3635b04314e571c80cd9639a16950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2763, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2796, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2890, 38, false);
#line 86 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2928, 72, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td></td>\r\n\r\n");
            EndContext();
#line 91 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                         if (User.IsInRole(SD.ManagerUser))
                        {

#line default
#line hidden
            BeginContext(3088, 34, true);
            WriteLiteral("                            <td>\r\n");
            EndContext();
#line 94 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                             if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                            {

#line default
#line hidden
            BeginContext(3246, 94, true);
            WriteLiteral("                                <div class=\"alignright\">\r\n                                    ");
            EndContext();
            BeginContext(3340, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b808da81dfe79fb3635b04314e571c80cd9639a20101", async() => {
                BeginContext(3420, 112, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-lock-open\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3536, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 101 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3674, 94, true);
            WriteLiteral("                                <div class=\"alignright\">\r\n                                    ");
            EndContext();
            BeginContext(3768, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b808da81dfe79fb3635b04314e571c80cd9639a23211", async() => {
                BeginContext(3849, 107, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-lock\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3960, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 109 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4033, 31, true);
            WriteLiteral("                        </td>\r\n");
            EndContext();
#line 111 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4148, 39, true);
            WriteLiteral("                            <td></td>\r\n");
            EndContext();
#line 115 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4214, 31, true);
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 119 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4264, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 121 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(4322, 40, true);
            WriteLiteral("            <p>No users available.</p>\r\n");
            EndContext();
#line 125 "C:\Users\nicko\source\repos\engsoftaero\TrabalhoEngSoftware\EngSoftwareForum\Areas\Admin\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4373, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
