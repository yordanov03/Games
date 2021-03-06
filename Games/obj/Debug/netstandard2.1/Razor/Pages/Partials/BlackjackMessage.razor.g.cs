#pragma checksum "C:\Games\Games\Pages\Partials\BlackjackMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8428363bc21f629e79c26a3b0794984548af419"
// <auto-generated/>
#pragma warning disable 1591
namespace Games.Pages.Partials
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Games\Games\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\Games\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Games\Games\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Games\Games\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Games\Games\_Imports.razor"
using Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Games\Games\_Imports.razor"
using Games.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
using Games.Models.Blackjack.Enums;

#line default
#line hidden
#nullable disable
    public partial class BlackjackMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.Dealing)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<span class=\"display-3 text-info\">Dealing...</span>\n");
#nullable restore
#line 14 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.InProgress)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "class", "display-3 text-primary");
            __builder.AddContent(5, "$");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
                                           Bet

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 18 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.Shuffling)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<span class=\"display-3 text-info\">Shuffling...</span>\n");
#nullable restore
#line 22 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
 if (State == GameState.EscortedOut)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<span class=\"display-3 text-danger\">The House is having you escorted out.</span>\n    <br>\n    ");
            __builder.AddMarkupContent(12, "<span>You won the game! Thanks for playing!</span>\n");
#nullable restore
#line 28 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Games\Games\Pages\Partials\BlackjackMessage.razor"
       
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
