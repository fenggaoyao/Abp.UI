#pragma checksum "D:\Project\angular\Abp.UI\Pages\Components\Tooltips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Components_Tooltips), @"mvc.1.0.razor-page", @"/Pages/Components/Tooltips.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Components/Tooltips.cshtml", typeof(AspNetCore.Pages_Components_Tooltips), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec9ba0c0de396ac2eb108c867c20a7ab5729ddd", @"/Pages/Components/Tooltips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"189c5b5f6e78862ee356594e9c0e93b8da3da2d8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Tooltips : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/css/demo.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-tooltip", "Tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-tooltip-top", "Tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-tooltip-right", "Tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-tooltip-bottom", "Tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Tag Helper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Rendered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleBundleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tab.AbpTabsTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabsTagHelper;
        private global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tab.AbpTabTagHelper __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Project\angular\Abp.UI\Pages\Components\Tooltips.cshtml"
  
    ViewData["Title"] = "Tooltips";

#line default
#line hidden
            BeginContext(127, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(145, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(150, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-style-bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd6248", async() => {
                    BeginContext(168, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(177, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-style", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd6667", async() => {
                    }
                    );
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleTagHelper>();
                    __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper);
                    __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(210, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bundling.TagHelpers.AbpStyleBundleTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bundling_TagHelpers_AbpStyleBundleTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(234, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(237, 227, true);
            WriteLiteral("\n<h2>Tooltips</h2>\n\n<p>Based on <a href=\"https://getbootstrap.com/docs/4.1/components/tooltips/\" target=\"_blank\"> Bootstrap Tooltips</a>.</p>\n\n<h4>Example</h4>\n\n<div class=\"demo-with-code\">\n    <div class=\"demo-area\">\n\n        ");
            EndContext();
            BeginContext(464, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd9395", async() => {
                BeginContext(498, 37, true);
                WriteLiteral("\n            Tooltip Default\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper.AbpTooltip = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(548, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(557, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd11229", async() => {
                BeginContext(595, 36, true);
                WriteLiteral("\n            Tooltip on top\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper.AbpTooltipTop = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(644, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(653, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd13066", async() => {
                BeginContext(693, 38, true);
                WriteLiteral("\n            Tooltip on right\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper.AbpTooltipRight = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(744, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(753, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd14907", async() => {
                BeginContext(794, 39, true);
                WriteLiteral("\n            Tooltip on bottom\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper.AbpTooltipBottom = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(855, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd16751", async() => {
                BeginContext(905, 45, true);
                WriteLiteral("\n            Disabled button Tooltip\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button.AbpButtonTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tooltip.AbpTooltipTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper);
#line 34 "D:\Project\angular\Abp.UI\Pages\Components\Tooltips.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.Disabled = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("disabled", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Button_AbpButtonTagHelper.Disabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tooltip_AbpTooltipTagHelper.AbpTooltip = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(963, 48, true);
            WriteLiteral("\n    </div>\n    <div class=\"code-area\">\n        ");
            EndContext();
            BeginContext(1011, 2292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-tabs", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd19083", async() => {
                BeginContext(1021, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1034, 629, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-tab", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd19483", async() => {
                    BeginContext(1076, 577, true);
                    WriteLiteral(@"
                <pre><code>
&lt;abp-button abp-tooltip=&quot;Tooltip&quot;&gt;
      Tooltip Default
&lt;/abp-button&gt;

&lt;abp-button abp-tooltip-top=&quot;Tooltip&quot;&gt;
      Tooltip on top
&lt;/abp-button&gt;

&lt;abp-button abp-tooltip-right=&quot;Tooltip&quot;&gt;
      Tooltip on right
&lt;/abp-button&gt;

&lt;abp-button abp-tooltip-bottom=&quot;Tooltip&quot;&gt;
      Tooltip on bottom
&lt;/abp-button&gt;

&lt;abp-button disabled=&quot;true&quot; abp-tooltip=&quot;Tooltip&quot;&gt;
      Disabled button Tooltip
&lt;/abp-button&gt;
</code></pre>
            ");
                    EndContext();
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tab.AbpTabTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper);
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper.Title = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 40 "D:\Project\angular\Abp.UI\Pages\Components\Tooltips.cshtml"
__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper.Active = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("active", __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper.Active, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1663, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(1676, 1607, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-tab", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec9ba0c0de396ac2eb108c867c20a7ab5729ddd22028", async() => {
                    BeginContext(1702, 1571, true);
                    WriteLiteral(@"
                <pre><code>
&lt;button class=&quot;btn&quot; type=&quot;button&quot; data-busy-text=&quot;Processing...&quot; data-toggle=&quot;tooltip&quot; data-placement=&quot;top&quot; title=&quot;&quot; data-original-title=&quot;Tooltip&quot;&gt;
    Tooltip Default
&lt;/button&gt;

&lt;button class=&quot;btn&quot; type=&quot;button&quot; data-busy-text=&quot;Processing...&quot; data-toggle=&quot;tooltip&quot; data-placement=&quot;top&quot; title=&quot;&quot; data-original-title=&quot;Tooltip&quot;&gt;
    Tooltip on top
&lt;/button&gt;

&lt;button class=&quot;btn&quot; type=&quot;button&quot; data-busy-text=&quot;Processing...&quot; data-toggle=&quot;tooltip&quot; data-placement=&quot;right&quot; title=&quot;&quot; data-original-title=&quot;Tooltip&quot;&gt;
     Tooltip on right
&lt;/button&gt;

&lt;button class=&quot;btn&quot; type=&quot;button&quot; data-busy-text=&quot;Processing...&quot; data-toggle=&quot;tooltip&quot; data-placement=&quot;bottom&quot; title=&quot;&quot; data-original-title=&quot;");
                    WriteLiteral(@"Tooltip&quot;&gt;
    Tooltip on bottom
&lt;/button&gt;

&lt;span class=&quot;d-inline-block&quot; tabindex=&quot;0&quot; data-toggle=&quot;tooltip&quot; data-placement=&quot;top&quot; title=&quot;&quot; data-original-title=&quot;Tooltip&quot;&gt;
    &lt;button class=&quot;btn&quot; disabled=&quot;disabled&quot; type=&quot;button&quot; data-busy-text=&quot;Processing...&quot; data-placement=&quot;top&quot; style=&quot;pointer-events: none;&quot;&gt;
        Disabled button Tooltip
    &lt;/button&gt;
&lt;/span&gt;
</code></pre>
            ");
                    EndContext();
                }
                );
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tab.AbpTabTagHelper>();
                __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper);
                __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabTagHelper.Title = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3283, 9, true);
                WriteLiteral("\n        ");
                EndContext();
            }
            );
            __Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabsTagHelper = CreateTagHelper<global::Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Tab.AbpTabsTagHelper>();
            __tagHelperExecutionContext.Add(__Volo_Abp_AspNetCore_Mvc_UI_Bootstrap_TagHelpers_Tab_AbpTabsTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3303, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.Demo.Pages.Components.TooltipsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.Demo.Pages.Components.TooltipsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.Demo.Pages.Components.TooltipsModel>)PageContext?.ViewData;
        public Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.Demo.Pages.Components.TooltipsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591