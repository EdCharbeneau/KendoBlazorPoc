using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Models
{
    public abstract class ComponentModelBase : IWidget
    {
        public abstract string WidgetName { get; }
    }
}
