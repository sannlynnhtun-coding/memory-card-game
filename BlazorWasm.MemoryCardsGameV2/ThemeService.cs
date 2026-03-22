using Microsoft.JSInterop;

namespace BlazorWasm.MemoryCardsGameV2;

public class ThemeService
{
    private readonly IJSRuntime _jsRuntime;
    private const string ThemeKey = "app-theme";
    public string CurrentTheme { get; private set; } = "light";

    public event Action? OnThemeChanged;

    public ThemeService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task InitializeAsync()
    {
        var savedTheme = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", ThemeKey);
        if (!string.IsNullOrEmpty(savedTheme))
        {
            CurrentTheme = savedTheme;
        }
        else
        {
            // Optional: Default to system preference
            // CurrentTheme = await IsSystemDark() ? "dark" : "light";
        }
    }

    public async Task ToggleThemeAsync()
    {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", ThemeKey, CurrentTheme);
        await ApplyThemeAsync();
        OnThemeChanged?.Invoke();
    }

    public async Task ApplyThemeAsync()
    {
        if (CurrentTheme == "dark")
        {
            await _jsRuntime.InvokeVoidAsync("eval", "document.documentElement.classList.add('dark')");
        }
        else
        {
            await _jsRuntime.InvokeVoidAsync("eval", "document.documentElement.classList.remove('dark')");
        }
    }
}
