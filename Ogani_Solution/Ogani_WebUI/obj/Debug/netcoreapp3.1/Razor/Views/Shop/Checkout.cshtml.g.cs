#pragma checksum "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\Shop\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658ccff129677e949d943a61b20887d931f46b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Checkout), @"mvc.1.0.view", @"/Views/Shop/Checkout.cshtml")]
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
#line 1 "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\_ViewImports.cshtml"
using Ogani_WebUI.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658ccff129677e949d943a61b20887d931f46b1e", @"/Views/Shop/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ada1b32a40d7fb0dd8db8233bb8fa8c4432c93", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\Shop\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero hero-normal"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero-categories"">
                    <div class=""hero-categories-all"">
                        <i class=""fa fa-bars""></i>
                        <span>All departments</span>
                    </div>
                    <ul>
                        <li><a href=""#"">Fresh Meat</a></li>
                        <li><a href=""#"">Vegetables</a></li>
                        <li><a href=""#"">Fruit & Nut Gifts</a></li>
                        <li><a href=""#"">Fresh Berries</a></li>
                        <li><a href=""#"">Ocean Foods</a></li>
                        <li><a href=""#"">Butter & Eggs</a></li>
                        <li><a href=""#"">Fastfood</a></li>
                        <li><a href=""#"">Fresh Onion</a></li>
                        <li><a href=""#"">Papayaya & Crisps</a></li>
                        <li><a href=""#"">Oatmeal</a></li>
     ");
            WriteLiteral(@"                   <li><a href=""#"">Fresh Bananas</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""hero-search"">
                    <div class=""hero-search-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658ccff129677e949d943a61b20887d931f46b1e4984", async() => {
                WriteLiteral(@"
                            <div class=""hero-search-categories"">
                                All Categories
                                <span class=""arrow_carrot-down""></span>
                            </div>
                            <input type=""text"" placeholder=""What do yo u need?"">
                            <button type=""submit"" class=""site-btn"">SEARCH</button>
                        ");
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
            WriteLiteral(@"
                    </div>
                    <div class=""hero-search-phone"">
                        <div class=""hero-search-phone-icon"">
                            <i class=""fa fa-phone""></i>
                        </div>
                        <div class=""hero-search-phone-text"">
                            <h5>+65 11.188.888</h5>
                            <span>support 24/7 time</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""breadcrumb-section set-bg"" data-setbg=""assets/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb-text"">
                    <h2>Checkout</h2>
                    <div class=""breadcrumb-option"">
                        <a href=""index-2.html"">Home</a>
                        <span>Checkout</span>
                    </div>
       ");
            WriteLiteral(@"         </div>
            </div>
        </div>
    </div>
</section>


<section class=""checkout spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h6>
                    <span class=""icon_tag_alt""></span> Have a coupon? <a href=""#"">Click here</a> to enter your code
                </h6>
            </div>
        </div>
        <div class=""checkout-form"">
            <h4>Billing Details</h4>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658ccff129677e949d943a61b20887d931f46b1e8305", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-8 col-md-6"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout-input"">
                                    <p>Fist Name<span>*</span></p>
                                    <input type=""text"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""checkout-input"">
                                    <p>Last Name<span>*</span></p>
                                    <input type=""text"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout-input"">
                            <p>Country<span>*</span></p>
                            <input type=""text"">
                        </div>
                        <div class=""");
                WriteLiteral(@"checkout-input"">
                            <p>Address<span>*</span></p>
                            <input type=""text"" placeholder=""Street Address"" class=""checkout-input-add"">
                            <input type=""text"" placeholder=""Apartment, suite, unite ect (optinal)"">
                        </div>
                        <div class=""checkout-input"">
                            <p>Town/City<span>*</span></p>
                            <input type=""text"">
                        </div>
                        <div class=""checkout-input"">
                            <p>Country/State<span>*</span></p>
                            <input type=""text"">
                        </div>
                        <div class=""checkout-input"">
                            <p>Postcode / ZIP<span>*</span></p>
                            <input type=""text"">
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                     ");
                WriteLiteral(@"           <div class=""checkout-input"">
                                    <p>Phone<span>*</span></p>
                                    <input type=""text"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""checkout-input"">
                                    <p>Email<span>*</span></p>
                                    <input type=""text"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout-input-checkbox"">
                            <label for=""acc"">
                                Create an account?
                                <input type=""checkbox"" id=""acc"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                        <p>
                            Create an account by en");
                WriteLiteral(@"tering the information below. If you are a returning customer
                            please login at the top of the page
                        </p>
                        <div class=""checkout-input"">
                            <p>Account Password<span>*</span></p>
                            <input type=""text"">
                        </div>
                        <div class=""checkout-input-checkbox"">
                            <label for=""diff-acc"">
                                Ship to a different address?
                                <input type=""checkbox"" id=""diff-acc"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                        <div class=""checkout-input"">
                            <p>Order notes<span>*</span></p>
                            <input type=""text"" placeholder=""Notes about your order, e.g. special notes for delivery."">
                        </div>
             ");
                WriteLiteral(@"       </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""checkout-order"">
                            <h4>Your Order</h4>
                            <div class=""checkout-order-products"">Products <span>Total</span></div>
                            <ul>
                                <li>Vegetable’s Package <span>$75.99</span></li>
                                <li>Fresh Vegetable <span>$151.99</span></li>
                                <li>Organic Bananas <span>$53.99</span></li>
                            </ul>
                            <div class=""checkout-order-subtotal"">Subtotal <span>$750.99</span></div>
                            <div class=""checkout-order-total"">Total <span>$750.99</span></div>
                            <div class=""checkout-input-checkbox"">
                                <label for=""acc-or"">
                                    Create an account?
                                    <input type=""checkbox"" id=""acc-or""");
                WriteLiteral(@">
                                    <span class=""checkmark""></span>
                                </label>
                            </div>
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adip elit, sed do eiusmod tempor incididunt
                                ut labore et dolore magna aliqua.
                            </p>
                            <div class=""checkout-input-checkbox"">
                                <label for=""payment"">
                                    Check Payment
                                    <input type=""checkbox"" id=""payment"">
                                    <span class=""checkmark""></span>
                                </label>
                            </div>
                            <div class=""checkout-input-checkbox"">
                                <label for=""paypal"">
                                    Paypal
                                    <input type=""checkbox"" id=""p");
                WriteLiteral(@"aypal"">
                                    <span class=""checkmark""></span>
                                </label>
                            </div>
                            <button type=""submit"" class=""site-btn"">PLACE ORDER</button>
                        </div>
                    </div>
                </div>
            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
