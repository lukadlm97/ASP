#pragma checksum "C:\Users\Luka\Desktop\ASP\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b75acdc7db1973416e4cb98777335fdd3977a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/ClientRestaurants.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Luka\Desktop\ASP\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b75acdc7db1973416e4cb98777335fdd3977a31", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7a9498867045fbda097e3208cbd1c6a5a509f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_ClientRestaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Luka\Desktop\ASP\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml"
  
    ViewData["Title"] = "ClientRestaurants";

#line default
#line hidden
            BeginContext(119, 33, true);
            WriteLiteral("\r\n<h2>Client Restaurants</h2>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(169, 256, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $.ajax(""/api/restaurants/"",
                { mehtod: ""get"" })
                .then(function (response) {
                    console.dir(response);
                });
        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.ClientRestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
