// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Games.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blackjack\BlazorGames\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blackjack\BlazorGames\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blackjack\BlazorGames\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blackjack\BlazorGames\_Imports.razor"
using Games;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blackjack\BlazorGames\_Imports.razor"
using Games.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blackjack\BlazorGames\Pages\Minesweeper.razor"
using Games.Models.Minesweeper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\Pages\Minesweeper.razor"
using Games.Models.Minesweeper.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blackjack\BlazorGames\Pages\Minesweeper.razor"
using Games.Pages.Partials;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/minesweeper")]
    public partial class Minesweeper : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Blackjack\BlazorGames\Pages\Minesweeper.razor"
       
    GameBoard board = new GameBoard();

    public int GetPlace(int value, int place)
    {
        if (value == 0) return 0;
        return ((value % (place * 10)) - (value % place)) / place;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        while (board.Status == GameStatus.InProgress && _navManager.Uri.Contains("minesweeper"))
        {
            await Task.Delay(500);
            var elapsedTime = (int)board.Stopwatch.Elapsed.TotalSeconds;
            var hundreds = GetPlace(elapsedTime, 100);
            var tens = GetPlace(elapsedTime, 10);
            var ones = GetPlace(elapsedTime, 1);

            await _jsRuntime.InvokeAsync<string>("setTime", hundreds, tens, ones);
        }

        await _jsRuntime.InvokeVoidAsync("Prism.highlightAll");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
