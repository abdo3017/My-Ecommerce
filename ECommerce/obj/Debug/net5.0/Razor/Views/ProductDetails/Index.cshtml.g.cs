#pragma checksum "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecb8626c9ec24d159eb665e17513ecd86e99560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Index), @"mvc.1.0.view", @"/Views/ProductDetails/Index.cshtml")]
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
#line 1 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecb8626c9ec24d159eb665e17513ecd86e99560", @"/Views/ProductDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c73885362c85f99ff2e0c4ca24164defc6e3b02", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.ViewModel.ProductViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProductsOfCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-hash", new global::Microsoft.AspNetCore.Html.HtmlString("product-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product__big__img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProductItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
  
	var check = false;
	if (ViewBag.Category != null)
		check = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Breadcrumb Begin -->\r\n<div class=\"breadcrumb-option\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-lg-12\">\r\n\t\t\t\t<div class=\"breadcrumb__links\">\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ecb8626c9ec24d159eb665e17513ecd86e995606160", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i> Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                     if (check)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ecb8626c9ec24d159eb665e17513ecd86e995607801", async() => {
#nullable restore
#line 17 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                                      Write(ViewBag.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ’s ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                         WriteLiteral(ViewBag.Category.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ecb8626c9ec24d159eb665e17513ecd86e9956010653", async() => {
                WriteLiteral("Shop ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span>");
#nullable restore
#line 23 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- Breadcrumb End -->
<!-- Product Details Section Begin -->
<section class=""product-details spad"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-6"" style=""text-align: center; display: flex;
				justify-content: center; align-items: center;overflow: hidden;
				flex-shrink: 0;width: 100%; height: 100%; object-fit: cover;"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ecb8626c9ec24d159eb665e17513ecd86e9956012909", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1144, "~/Files/Imgs/Product/", 1144, 21, true);
#nullable restore
#line 37 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
AddHtmlAttributeValue("", 1165, Model.Image, 1165, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-lg-6\">\r\n\t\t\t\t<div class=\"product__details__text\">\r\n\t\t\t\t\t<h3>");
#nullable restore
#line 41 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Brand: ");
#nullable restore
#line 41 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                            Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h3>
					<div class=""rating"">
						<i class=""fa fa-star""></i>
						<i class=""fa fa-star""></i>
						<i class=""fa fa-star""></i>
						<i class=""fa fa-star""></i>
						<i class=""fa fa-star""></i>
						<span>( 138 reviews )</span>
					</div>
					<div class=""product__details__price"">$ ");
#nullable restore
#line 50 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 51 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<div class=\"product__details__button\">\r\n\t\t\t\t\t\t<div class=\"quantity\">\r\n\t\t\t\t\t\t\t<span>Quantity:</span>\r\n\t\t\t\t\t\t\t<div class=\"pro-qty\">\r\n\t\t\t\t\t\t\t\t<input type=\"text\" value=\"1\"\r\n\t\t\t\t\t\t\t\t\t   min=\"1\"");
            BeginWriteAttribute("max", " max=\"", 1856, "\"", 1877, 1);
#nullable restore
#line 57 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 1862, Model.Quantity, 1862, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly=""readonly"" name=""Quantity"">
							</div>
						</div>
						<a href=""#"" class=""cart-btn""><span class=""icon_bag_alt""></span> Add to cart</a>
						<ul>
							<li><a href=""#""><span class=""icon_heart_alt""></span></a></li>
						</ul>
					</div>
					<div class=""product__details__widget"">
						<ul>
							<li>
								<span>Availability:</span>
									<label for=""stockin"">
										In Stock
									</label>
							
							</li>
							<li>
								<span>Available color:</span>
								<div class=""color__checkbox"">
");
#nullable restore
#line 77 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                     foreach (var item in @Model.Colors)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<label");
            BeginWriteAttribute("for", " for=\"", 2507, "\"", 2523, 1);
#nullable restore
#line 79 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2513, item.Name, 2513, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"radio\" name=\"color__radio\"");
            BeginWriteAttribute("id", " id=\"", 2577, "\"", 2592, 1);
#nullable restore
#line 80 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2582, item.Name, 2582, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t<span");
            BeginWriteAttribute("class", " class=\"", 2612, "\"", 2643, 3);
            WriteAttributeValue("", 2620, "checkmark", 2620, 9, true);
#nullable restore
#line 81 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue(" ", 2629, item.Name, 2630, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2640, "-bg", 2640, 3, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n\t\t\t\t\t\t\t\t\t\t</label>\r\n");
#nullable restore
#line 83 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t<span>Available size:</span>\r\n\t\t\t\t\t\t\t\t<div class=\"size__btn\">\r\n");
#nullable restore
#line 89 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                     foreach (var item in @Model.Sizes)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<label");
            BeginWriteAttribute("for", " for=\"", 2874, "\"", 2894, 2);
#nullable restore
#line 91 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2880, item.Name, 2880, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2890, "-btn", 2890, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 2928, "\"", 2947, 2);
#nullable restore
#line 92 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2933, item.Name, 2933, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2943, "-btn", 2943, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 93 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</label>\r\n");
#nullable restore
#line 95 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</div>
							</li>
							<li>
								<span>Promotions:</span>
								<p>Free shipping</p>
							</li>
						</ul>
					</div>
				</div>
			</div>
			<div class=""col-lg-12"">
				<div class=""product__details__tab"">
					<ul class=""nav nav-tabs"" role=""tablist"">
						<li class=""nav-item"">
							<a class=""nav-link active"" data-toggle=""tab""  role=""tab"">Description</a>
						</li>

					</ul>
					<div class=""tab-content"">
						<div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
							<p>
								");
#nullable restore
#line 117 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-lg-12 text-center\">\r\n\t\t\t\t<div class=\"related__title\">\r\n\t\t\t\t\t<h5>RELATED PRODUCTS</h5>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 130 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
             foreach (var item in ViewBag.relatedproducts)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ecb8626c9ec24d159eb665e17513ecd86e9956022518", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 132 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 132 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 133 "C:\Users\Abdelrahman\source\repos\ECommerce\ECommerce\Views\ProductDetails\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n<!-- Product Details Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.ViewModel.ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
