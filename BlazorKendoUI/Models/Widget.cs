using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Models
{
    public abstract class WidgetModelBase
    {
        protected abstract string WidgetName { get; }

        public string Id { get; set; }

        public WidgetModelBase()
        {
            this.Id = $"Kendo{ WidgetName }_{ Guid.NewGuid().ToString()}";
        }
    }
}
