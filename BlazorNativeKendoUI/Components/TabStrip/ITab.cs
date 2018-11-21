using Microsoft.AspNetCore.Blazor;

namespace BlazorNativeKendoUI.Components.TabStrip
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}