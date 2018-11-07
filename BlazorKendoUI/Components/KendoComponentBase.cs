using BlazorKendoUI.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Components
{
    public abstract class KendoComponentBase : BlazorComponent, IDisposable
    {
        private bool shouldRender = true;

        protected ElementRef element;

        protected override void OnAfterRender()
        {
            if (shouldRender)
            {
                KendoUIInterop.Init(element, GetModel(), this);

                shouldRender = false;
            }
        }

        public void Dispose()
        {
            KendoUIInterop.Dispose(element);
        }

        protected abstract ComponentModelBase GetModel();
    }
}
