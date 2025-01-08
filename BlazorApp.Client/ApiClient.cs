using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Client;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private readonly NavigationManager _navigationManager;

    public ApiClient(HttpClient httpClient, NavigationManager navigationManager)
    {
        _httpClient = httpClient;
        _navigationManager = navigationManager;
    }

    public GridDevExtremeDataSource<Item> GetItemDataSource() => new(_httpClient.GetStreamAsync, _navigationManager.ToAbsoluteUri("api/item"));
}
