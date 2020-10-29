#pragma checksum "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60be2bcf10661cd610c9c54558cd0b3dfed97408"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSignalRApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\waekdo\Desktop\BlazorSignalRApp\Client\Pages\Index.razor"
       
    private bool Approved;
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string,bool>("ReceiveMessage", (user, message,Approved) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task ToggleApprovedAsync(bool approved)
    {
        Console.WriteLine("Toggle Approved " + approved);
        if (approved)
        {
            //await HttpClient.PostJsonAsync<bool>($"../api/Approve", null);
            Approved = true;
        }
        else
        {
            //await HttpClient.PostJsonAsync<bool>($"../api/Disapprove", null);
            Approved = false;
        }
    }


    Task Send() =>
    hubConnection.SendAsync("SendMessage", userInput, messageInput,Approved);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591