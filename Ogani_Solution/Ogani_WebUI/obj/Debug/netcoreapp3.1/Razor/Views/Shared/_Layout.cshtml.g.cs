#pragma checksum "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c176dbcd07939ed98ce7428e1828f28965677a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c176dbcd07939ed98ce7428e1828f28965677a8", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ada1b32a40d7fb0dd8db8233bb8fa8c4432c93", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Navbar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"az\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c176dbcd07939ed98ce7428e1828f28965677a84632", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""description"" content=""Ogani Template"">
    <meta name=""keywords"" content=""Ogani, unica, creative, html"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Ogani | ");
#nullable restore
#line 10 "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\Shared\_Layout.cshtml"
              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c176dbcd07939ed98ce7428e1828f28965677a85457", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <link href=""https://fonts.googleapis.com/css2?family=Cairo:wght@200;300;400;600;900&amp;display=swap"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=""assets/css/bootstrap.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/font-awesome.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/elegant-icons.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/nice-select.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/jquery-ui.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/owl.carousel.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/slicknav.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""assets/css/style.css"" type=""text/css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c176dbcd07939ed98ce7428e1828f28965677a88079", async() => {
                WriteLiteral(@"
    <div id=""preloder"">
        <div class=""loader""></div>
    </div>

    <div class=""humberger-menu-overlay""></div>
    <div class=""humberger-menu-wrapper"">
        <div class=""humberger-menu-logo"">
            <a href=""#""><img src=""assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 1452, "\"", 1458, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
        </div>
        <div class=""humberger-menu-cart"">
            <ul>
                <li><a href=""#""><i class=""fa fa-heart""></i> <span>1</span></a></li>
                <li><a href=""#""><i class=""fa fa-shopping-bag""></i> <span>3</span></a></li>
            </ul>
            <div class=""header-cart-price"">item: <span>$150.00</span></div>
        </div>
        <div class=""humberger-menu-widget"">
            <div class=""header-top-right-language"">
                <img src=""assets/img/language.png""");
                BeginWriteAttribute("alt", " alt=\"", 1980, "\"", 1986, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div>English</div>
                <span class=""arrow_carrot-down""></span>
                <ul>
                    <li><a href=""#"">Spanis</a></li>
                    <li><a href=""#"">English</a></li>
                </ul>
            </div>
            <div class=""header-top-right-auth"">
                <a href=""#""><i class=""fa fa-user""></i> Login</a>
            </div>
        </div>
        <nav class=""humberger-menu-nav mobile-menu"">
           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c176dbcd07939ed98ce7428e1828f28965677a89951", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </nav>
        <div id=""mobile-menu-wrap""></div>
        <div class=""header-top-right-social"">
            <a href=""#""><i class=""fa fa-facebook""></i></a>
            <a href=""#""><i class=""fa fa-twitter""></i></a>
            <a href=""#""><i class=""fa fa-linkedin""></i></a>
            <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
        </div>
        <div class=""humberger-menu-contact"">
            <ul>
                <li><i class=""fa fa-envelope""></i> <a href=""https://colorlib.com/cdn-cgi/l/email-protection"" class=""-cf_email-"" data-cfemail=""aac2cfc6c6c5eac9c5c6c5d8c6c3c884c9c5c7"">[email&#160;protected]</a></li>
                <li>Free Shipping for all Order of $99</li>
            </ul>
        </div>
    </div>


    <header class=""header"">
        <div class=""header-top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6"">
                        <div class=""header-top-left"">
                        ");
                WriteLiteral(@"    <ul>
                                <li><i class=""fa fa-envelope""></i> <a href=""https://colorlib.com/cdn-cgi/l/email-protection"" class=""-cf_email-"" data-cfemail=""9ff7faf3f3f0dffcf0f3f0edf3f6fdb1fcf0f2"">[email&#160;protected]</a></li>
                                <li>Free Shipping for all Order of $99</li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6"">
                        <div class=""header-top-right"">
                            <div class=""header-top-right-social"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-linkedin""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
                            </div>
                            <div class=""header-top-right-language"">
        ");
                WriteLiteral("                        <img src=\"assets/img/language.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4602, "\"", 4608, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div>English</div>
                                <span class=""arrow_carrot-down""></span>
                                <ul>
                                    <li><a href=""#"">Spanis</a></li>
                                    <li><a href=""#"">English</a></li>
                                </ul>
                            </div>
                            <div class=""header-top-right-auth"">
                                <a href=""#""><i class=""fa fa-user""></i> Login</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""header-logo"">
                        <a href=""index-2.html""><img src=""assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 5520, "\"", 5526, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <nav class=\"header-menu\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c176dbcd07939ed98ce7428e1828f28965677a814797", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </nav>
                </div>
                <div class=""col-lg-3"">
                    <div class=""header-cart"">
                        <ul>
                            <li><a href=""#""><i class=""fa fa-heart""></i> <span>1</span></a></li>
                            <li><a href=""#""><i class=""fa fa-shopping-bag""></i> <span>3</span></a></li>
                        </ul>
                        <div class=""header-cart-price"">item: <span>$150.00</span></div>
                    </div>
                </div>
            </div>
            <div class=""humberger-open"">
                <i class=""fa fa-bars""></i>
            </div>
        </div>
    </header>


    ");
#nullable restore
#line 142 "D:\Ogani Project\Ogani_Solution\Ogani_WebUI\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";


    <footer class=""footer spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-6"">
                    <div class=""footer-about"">
                        <div class=""footer-about-logo"">
                            <a href=""index-2.html""><img src=""assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 6794, "\"", 6800, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                        </div>
                        <ul>
                            <li>Address: 60-49 Road 11378 New York</li>
                            <li>Phone: +65 11.188.888</li>
                            <li>Email: <a href=""https://colorlib.com/cdn-cgi/l/email-protection"" class=""-cf_email-"" data-cfemail=""167e737a7a795675797a79647a7f743875797b"">[email&#160;protected]</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-6 offset-lg-1"">
                    <div class=""footer-widget"">
                        <h6>Useful Links</h6>
                        <ul>
                            <li><a href=""#"">About Us</a></li>
                            <li><a href=""#"">About Our Shop</a></li>
                            <li><a href=""#"">Secure Shopping</a></li>
                            <li><a href=""#"">Delivery infomation</a></li>
                            <li><a href=""#"">Privacy Policy</a></");
                WriteLiteral(@"li>
                            <li><a href=""#"">Our Sitemap</a></li>
                        </ul>
                        <ul>
                            <li><a href=""#"">Who We Are</a></li>
                            <li><a href=""#"">Our Services</a></li>
                            <li><a href=""#"">Projects</a></li>
                            <li><a href=""#"">Contact</a></li>
                            <li><a href=""#"">Innovation</a></li>
                            <li><a href=""#"">Testimonials</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-12"">
                    <div class=""footer-widget"">
                        <h6>Join Our Newsletter Now</h6>
                        <p>Get E-mail updates about our latest shop and special offers.</p>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c176dbcd07939ed98ce7428e1828f28965677a819402", async() => {
                    WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Enter your mail\">\r\n                            <button type=\"submit\" class=\"site-btn\">Subscribe</button>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <div class=""footer-widget-social"">
                            <a href=""#""><i class=""fa fa-facebook""></i></a>
                            <a href=""#""><i class=""fa fa-instagram""></i></a>
                            <a href=""#""><i class=""fa fa-twitter""></i></a>
                            <a href=""#""><i class=""fa fa-pinterest""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""footer-copyright"">
                        <div class=""footer-copyright-text"">
                            <p>
                                Copyright &copy;
                                <script type=""text/javascript"">document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart"" aria-hidden=""true""></i> by <a href=""https://colorlib.com/"" target=""_blank"">Colorlib</a>
          ");
                WriteLiteral("                  </p>\r\n                        </div>\r\n                        <div class=\"footer-copyright-payment\"><img src=\"assets/img/payment-item.png\"");
                BeginWriteAttribute("alt", " alt=\"", 10099, "\"", 10105, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    </div>
                </div>
            </div>
        </div>
    </footer>


    <script src=""assets/js/jquery-3.3.1.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/bootstrap.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/jquery.nice-select.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/jquery-ui.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/jquery.slicknav.js"" type=""text/javascript""></script>
    <script src=""assets/js/mixitup.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/owl.carousel.min.js"" type=""text/javascript""></script>
    <script src=""assets/js/main.js"" type=""text/javascript""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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