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
    
    #line 1 "..\..\Views\IlaroAdmin\Delete.cshtml"
    using Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/Delete.cshtml")]
    public partial class _Views_IlaroAdmin_Delete_cshtml : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.DeleteViewModel>
    {

#line 58 "..\..\Views\IlaroAdmin\Delete.cshtml"
public System.Web.WebPages.HelperResult DisplayRecordHierarchy(RecordHierarchy record)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 59 "..\..\Views\IlaroAdmin\Delete.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 61 "..\..\Views\IlaroAdmin\Delete.cshtml"
WriteTo(__razor_helper_writer, record.Entity.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": ");


#line 61 "..\..\Views\IlaroAdmin\Delete.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(record.DisplayName, "Edit", new { entityName = record.Entity.Name, key = record.KeyValue }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 62 "..\..\Views\IlaroAdmin\Delete.cshtml"
        

#line default
#line hidden

#line 62 "..\..\Views\IlaroAdmin\Delete.cshtml"
         if (record.SubRecordsHierarchies.Any())
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul>\r\n");


#line 65 "..\..\Views\IlaroAdmin\Delete.cshtml"
                

#line default
#line hidden

#line 65 "..\..\Views\IlaroAdmin\Delete.cshtml"
                 foreach (var subRecord in record.SubRecordsHierarchies)
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    ");


#line 67 "..\..\Views\IlaroAdmin\Delete.cshtml"
WriteTo(__razor_helper_writer, DisplayRecordHierarchy(subRecord));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 68 "..\..\Views\IlaroAdmin\Delete.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 70 "..\..\Views\IlaroAdmin\Delete.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 72 "..\..\Views\IlaroAdmin\Delete.cshtml"


#line default
#line hidden
});

#line 72 "..\..\Views\IlaroAdmin\Delete.cshtml"
}
#line default
#line hidden

        public _Views_IlaroAdmin_Delete_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\Delete.cshtml"
  
    Layout = "~/Views/IlaroAdmin/_Layout.cshtml";
    ViewBag.Title = string.Format(IlaroAdminResources.Delete_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 11 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(IlaroAdminResources.Index_Title, "Index"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Group, "Group", new { groupName = Model.Entity.Verbose.Group }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 13 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Plural, "List", new { entityName = Model.Entity.Name }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\IlaroAdmin\Delete.cshtml"
                      Write(string.Format(IlaroAdminResources.Delete_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 18 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Model.Entity.Verbose.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 20 "..\..\Views\IlaroAdmin\Delete.cshtml"
 using (Html.BeginForm("Delete", "IlaroAdmin", FormMethod.Post, new { @class = "form-horizontal" }))
{
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Delete.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Delete.cshtml"
                             
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.Hidden("EntityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                 
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.Hidden("Key", Model.Entity.Key.Value));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                               


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"controls col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(IlaroAdminResources.DeleteText);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 32 "..\..\Views\IlaroAdmin\Delete.cshtml"

    for (int i = 0; i < Model.PropertiesDeleteOptions.Count; i++)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1276), Tuple.Create("\"", 1345)
            
            #line 36 "..\..\Views\IlaroAdmin\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 1282), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => Model.PropertiesDeleteOptions[i].DeleteOption)
            
            #line default
            #line hidden
, 1282), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                                                                                   Write(Model.PropertiesDeleteOptions[i].PropertyName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"controls col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\IlaroAdmin\Delete.cshtml"
           Write(Html.HiddenFor(m => Model.PropertiesDeleteOptions[i].PropertyName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Views\IlaroAdmin\Delete.cshtml"
           Write(Html.DropDownListFor(m => Model.PropertiesDeleteOptions[i].DeleteOption, Model.PropertiesDeleteOptions[i].DeleteOption.GetSelectList(), new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 42 "..\..\Views\IlaroAdmin\Delete.cshtml"
    }


            
            #line default
            #line hidden
WriteLiteral("    <h4>If all foreign entities are to be cascade delete, all of the following it" +
"ems will be deleted:</h4>\r\n");

WriteLiteral("    <ul");

WriteLiteral(" class=\"list-delete\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 46 "..\..\Views\IlaroAdmin\Delete.cshtml"
   Write(DisplayRecordHierarchy(Model.RecordHierarchy));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n");

            
            #line 48 "..\..\Views\IlaroAdmin\Delete.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                     Write(IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2183), Tuple.Create("\"", 2209)
            
            #line 52 "..\..\Views\IlaroAdmin\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 2190), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit")
            
            #line default
            #line hidden
, 2190), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 52 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                                                                      Write(IlaroAdminResources.Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2321), Tuple.Create("\"", 2347)
            
            #line 53 "..\..\Views\IlaroAdmin\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 2328), Tuple.Create<System.Object, System.Int32>(Url.Action("List")
            
            #line default
            #line hidden
, 2328), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                          Write(IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n");

            
            #line 56 "..\..\Views\IlaroAdmin\Delete.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
