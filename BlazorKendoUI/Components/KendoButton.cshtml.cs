using BlazorKendoUI.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Components
{
    public class KendoButtonBase : KendoComponentBase
    {
        [Parameter]
        protected RenderFragment ChildContent { get; set; }

        [Parameter]
        Action OnButtonClick { get; set; }
        [JSInvokable]
        public void ButtonClick() => OnButtonClick.Invoke();

        protected override ComponentModelBase GetModel()
        {
            return new ButtonModel();
        }
    }
}
