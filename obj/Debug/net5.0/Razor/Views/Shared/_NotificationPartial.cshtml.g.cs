#pragma checksum "G:\Practice\Web ASP\SweetAlertNotifications\SweetAlertNotifications\Views\Shared\_NotificationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f4d8265c5b0c1bd606794b5322513eaa03c52c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NotificationPartial), @"mvc.1.0.view", @"/Views/Shared/_NotificationPartial.cshtml")]
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
#nullable restore
#line 1 "G:\Practice\Web ASP\SweetAlertNotifications\SweetAlertNotifications\Views\_ViewImports.cshtml"
using SweetAlertNotifications;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4d8265c5b0c1bd606794b5322513eaa03c52c9", @"/Views/Shared/_NotificationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c1ef04145398234e35f69ce4ec51d4d215d1ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NotificationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    var msg = ");
#nullable restore
#line 2 "G:\Practice\Web ASP\SweetAlertNotifications\SweetAlertNotifications\Views\Shared\_NotificationPartial.cshtml"
          Write(TempData["Message"]!=null? Html.Raw(TempData["Message"]) : Html.Raw("undefined"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    if (msg) {
        if (msg.type == ""Basic"") {
            swal.fire({
                text: msg.message
            });
        }
        else if (msg.type == ""TitleWithTextUnder"") {
            swal.fire({
                title: msg.title,
                text: msg.message,
                icon: msg.icon
            });
        }
        else if (msg.type == ""ModalWithFooter"") {
            swal.fire({
                title: msg.title,
                text: msg.message,
                icon: msg.icon,
                footer: msg.footer
            });
        }
        else if (msg.type == ""ConfirmDialogWithConfirmButton"") {
            swal.fire({
                title: msg.title,
                text: msg.message,
                icon: msg.icon,
                showCancelButton: msg.showCancelButton,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: msg.confirmButtonText
            }).then((resu");
            WriteLiteral(@"lt) => {
                if (result.isConfirmed) {
                    Swal.fire(
                        msg.titleConfirm,
                        msg.messageConfirm,
                        'success'
                    )
                }
            });
        }
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
