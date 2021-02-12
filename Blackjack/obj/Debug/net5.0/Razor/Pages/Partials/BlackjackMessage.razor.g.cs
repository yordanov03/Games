#pragma checksum "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bc161265405eceb57f6e925333adb0f1196b43"
// <auto-generated/>
#pragma warning disable 1591
namespace Blackjack.Pages.Partials
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blackjack\Blackjack\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blackjack\Blackjack\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blackjack\Blackjack\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blackjack\Blackjack\_Imports.razor"
using Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blackjack\Blackjack\_Imports.razor"
using Pages.Partials;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Blackjack\Blackjack\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
using Models.Enums;

#line default
#line hidden
#nullable disable
    public partial class BlackjackMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.Dealing)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<span class=\"display-3 text-info\">Dealing...</span>");
#nullable restore
#line 14 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.InProgress)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "class", "display-3 text-primary");
            __builder.AddContent(3, "$");
            __builder.AddContent(4, 
#nullable restore
#line 18 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
                                           Bet

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.Shuffling)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<span class=\"display-3 text-info\">Shuffling...</span>");
#nullable restore
#line 23 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Blackjack\Blackjack\Pages\Partials\BlackjackMessage.razor"
      
    [Parameter]
    public GameState State { get; set; }

    [Parameter]
    public decimal Bet { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
