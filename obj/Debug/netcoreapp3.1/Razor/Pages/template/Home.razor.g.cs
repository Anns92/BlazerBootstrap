#pragma checksum "C:\Users\Anns\source\repos\BlazorApp1\Pages\template\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b098c62e88e23776db47c6d0f03f19f71a0efb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.template
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anns\source\repos\BlazorApp1\_Imports.razor"
using BlazorApp1.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""banner-area relative"" id=""home"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row fullscreen d-flex justify-content-center align-items-center"">
            <div class=""banner-content col-lg-10 col-md-12 justify-content-center"">
                <h6 class=""text-uppercase"">Whenever we bake, bake with our heart</h6>
                <h1>
                    Love with baking items
                </h1>
                <p class=""text-white mx-auto"">
                    Since Americans in the South began roasting pigs publicly, Barbecues have been a staple of North American living. For many, grilling becomes a routine mealtime activity.
                </p>
                <a href=""#"" class=""primary-btn squire text-uppercase mt-10"">Check Our Menu</a>
            </div>
        </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, @"<section class=""home-about-area section-gap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9"">
                <h6 class=""text-uppercase"">Brand new app to blow your mind</h6>
                <h1>
                    We’ve baked every item
                    from the core of our heart to serve you
                </h1>
                <p>
                    <span>We are here to listen from you deliver exellence by any means</span>
                </p>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim.
                </p>
                <a class=""primary-btn squire mx-auto mt-20"" href=""#"">Get Started Now</a>
            </div>
        </div>
    </div>
    <img class=""about-img"" src=""img/about-img.png"" alt>
</section>


");
            __builder.AddMarkupContent(2, "<section class=\"item-category-area section-gap\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            <div class=\"col-md-12 pb-80 header-text text-center\">\r\n                <h1 class=\"pb-10\">Category of available items</h1>\r\n                <p>\r\n                    They are grilling celebrities in their own right.\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <div class=\"single-cat-item\">\r\n                    <div class=\"thumb\">\r\n                        <img class=\"img-fluid\" src=\"img/c1.jpg\" alt>\r\n                    </div>\r\n                    <a href=\"#\"><h4>Pizza</h4></a>\r\n                    <p>\r\n                        inappropriate behavior is often laughed off as “boys will be.\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <div class=\"single-cat-item\">\r\n                    <div class=\"thumb\">\r\n                        <img class=\"img-fluid\" src=\"img/c2.jpg\" alt>\r\n                    </div>\r\n                    <a href=\"#\"><h4>Bread</h4></a>\r\n                    <p>\r\n                        inappropriate behavior is often laughed off as “boys will be.\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <div class=\"single-cat-item\">\r\n                    <div class=\"thumb\">\r\n                        <img class=\"img-fluid\" src=\"img/c3.jpg\" alt>\r\n                    </div>\r\n                    <a href=\"#\"><h4>Burgers</h4></a>\r\n                    <p>\r\n                        inappropriate behavior is often laughed off as “boys will be.\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6\">\r\n                <div class=\"single-cat-item\">\r\n                    <div class=\"thumb\">\r\n                        <img class=\"img-fluid\" src=\"img/c4.jpg\" alt>\r\n                    </div>\r\n                    <a href=\"#\"><h4>Chicken</h4></a>\r\n                    <p>\r\n                        inappropriate behavior is often laughed off as “boys will be.\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <a class=\"primary-btn mx-auto mt-80\" href=\"#\">View Full Menu</a>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, @"<section class=""about-video-area section-gap"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-6 about-video-left"">
                <h6 class=""text-uppercase"">Brand new app to blow your mind</h6>
                <h1>
                    We’ve made a life <br>
                    that will change you
                </h1>
                <p>
                    <span>We are here to listen from you deliver exellence</span>
                </p>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed doeiusmo d tempor incididunt ut labore et dolore magna aliqua.
                </p>
                <a class=""primary-btn"" href=""#"">Get Started Now</a>
            </div>
            <div class=""col-lg-6 about-video-right justify-content-center align-items-center d-flex"">
                <a class=""play-btn"" href=""https://www.youtube.com/watch?v=ARA0AxrnHdM""><img class=""img-fluid mx-auto"" src=""img/play.png"" alt></a>
            </div>
        </div>
    </div>
</section>


");
            __builder.AddMarkupContent(4, "<section class=\"review-area section-gap relative\">\r\n    <div class=\"overlay overlay-bg\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            <div class=\"col-md-9 pb-40 header-text text-center\">\r\n                <h1 class=\"pb-10 text-white\">Enjoy our Client’s Review</h1>\r\n                <p>\r\n                    Who are in extremely love with eco friendly system.\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"active-review-carusel\">\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Fannie Rowe</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Hulda Sutton</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Fannie Rowe</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Hulda Sutton</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Fannie Rowe</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Hulda Sutton</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Fannie Rowe</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n                <div class=\"single-review item\">\r\n                    <img src=\"img/r1.png\" alt>\r\n                    <div class=\"title justify-content-start d-flex\">\r\n                        <a href=\"#\"><h4>Hulda Sutton</h4></a>\r\n                        <div class=\"star\">\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star checked\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                            <span class=\"fa fa-star\"></span>\r\n                        </div>\r\n                    </div>\r\n                    <p>\r\n                        Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker. Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker.\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591