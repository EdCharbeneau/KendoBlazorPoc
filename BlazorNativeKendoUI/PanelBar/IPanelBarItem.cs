using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorNativeKendoUI.PanelBar
{
    public interface IPanelBarItem
    {
        bool Selected { get; set; }
        bool Expanded { get; set; }
    }
}
