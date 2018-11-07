using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Models
{
    public abstract class ComponentModelBase : IComponent
    {
        public abstract string ComponentName { get; }
    }
}
