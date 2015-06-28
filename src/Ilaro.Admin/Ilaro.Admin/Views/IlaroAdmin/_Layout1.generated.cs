﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/_Layout.cshtml")]
    public partial class _Views_IlaroAdmin__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_IlaroAdmin__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\IlaroAdmin\_Layout.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 8 "..\..\Views\IlaroAdmin\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"/ira/css/bootstrap_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/font-awesome_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/bootstrap-datetimepicker_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/chosen_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/bootstrap-spinedit_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/bootstrap-markdown_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/summernote_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/bootstrap-duallistbox_min_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/ira/css/site_css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteLiteral(" src=\"/ira/Script/jquery-2_1_0_min_js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 21 "..\..\Views\IlaroAdmin\_Layout.cshtml"
Write(RenderSection("Header", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"navbar navbar-default navbar-static-top\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n            <h1>");

            
            #line 26 "..\..\Views\IlaroAdmin\_Layout.cshtml"
           Write(Html.ActionLink("Admin", "Index", "IlaroAdmin", null, new { @class = "navbar-brand" }));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");

            
            #line 28 "..\..\Views\IlaroAdmin\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\IlaroAdmin\_Layout.cshtml"
              Html.RenderPartial("_UserInfo");
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"breadcrumb-container\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\IlaroAdmin\_Layout.cshtml"
       Write(RenderSection("Breadcrumb", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 36 "..\..\Views\IlaroAdmin\_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\IlaroAdmin\_Layout.cshtml"
          Html.RenderAction("Messages");
            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Views\IlaroAdmin\_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Views\IlaroAdmin\_Layout.cshtml"
           Write(RenderSection("Sidebar", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr>\r\n        <footer>\r\n           " +
" <p>© <a");

WriteLiteral(" href=\"https://github.com/rgonek/Ilaro.Admin\"");

WriteLiteral(">Ilaro.Admin</a> ");

            
            #line 47 "..\..\Views\IlaroAdmin\_Layout.cshtml"
                                                                            Write(DateTime.Now.ToString("yyyy"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </footer>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"modal\"");

WriteLiteral(" class=\"modal hide fade\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" id=\"modal-image\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <script");

WriteLiteral(" src=\"/ira/Script/jquery_validate_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/jquery_validate_unobtrusive_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/chosen_jquery_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/moment_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/bootstrap-datetimepicker_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/bootstrap_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/bootstrap-spinedit_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/marked_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/bootstrap-markdown_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/summernote_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/jquery_bootstrap-duallistbox_min_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/ilaro_js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/ira/Script/bootstrap_file-input_js\"");

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 70 "..\..\Views\IlaroAdmin\_Layout.cshtml"
Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
