using BlazorKendoUI.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.JSInterop;

namespace BlazorKendoUI
{
    public static class KendoUIInterop
    {
        public static void Init(ElementRef element, IComponent model, object componentRef)
        {
            JSRuntime.Current.InvokeAsync<bool>($"KendoUI.Interop.{model.ComponentName}.Init", element, model, new DotNetObjectRef(componentRef));
        }

        public static void Update(ElementRef element, IComponent model)
        {
            JSRuntime.Current.InvokeAsync<bool>($"KendoUI.Interop.{model.ComponentName}.Update", element, model);
        }

        public static void Dispose(ElementRef element)
        {
            JSRuntime.Current.InvokeAsync<bool>("KendoUI.Interop.Widget.Dispose", element);
        }
    }
}
