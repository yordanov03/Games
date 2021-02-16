#pragma checksum "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28de81286d234a41365830a53ed403a700126320"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
using Games.Models.TicTacToe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
using Games.Pages.Partials;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tictactoe")]
    public partial class TicTacToe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Games.Shared.PageTitle>(0);
            __builder.AddAttribute(1, "Title", "Tic Tac Toe");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n\n\n");
#nullable restore
#line 18 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
 if (!board.GameComplete)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "h2");
            __builder.AddContent(5, 
#nullable restore
#line 20 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
         board.CurrentTurn

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "\'s Turn!");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 21 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "h2");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
         board.GetGameCompleteMessage()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-success");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
                                                                                    () => board.Reset()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Reset");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 25 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "tictactoe-board");
            __builder.AddMarkupContent(20, "\n");
#nullable restore
#line 28 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
     for (int i = 0; i < 3; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "tictacttoe-column");
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 31 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
             for (int j = 0; j < 3; j++)
            {
                int x = i;
                int y = j;

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "tictactoe-gamepiece" + "\n                         tictactoe-" + (
#nullable restore
#line 36 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
                                    board.Board[i,j].Style.ToString().ToLower()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
                                                                                             () => board.PieceClicked(x,y)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "style", 
#nullable restore
#line 37 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
                              board.IsGamePieceAWinningPiece(i, j)? "opacity: 0.6" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 38 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 40 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Blackjack\BlazorGames\Pages\TicTacToe.razor"
       
    GameBoard board = new GameBoard();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await _jsRuntime.InvokeVoidAsync("Prism.highlightAll");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591