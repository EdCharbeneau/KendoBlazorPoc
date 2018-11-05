using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI.Models
{
    public class GridModel : WidgetModelBase
    {
        public override string WidgetName { get => "Grid"; }

        public IList<GridColumn> Columns { get; set; }

        public IEnumerable Data { get; set; }

        public bool Sortable { get; set; }
    }

    public class GridColumn
    {
        public string Field { get; set; }
        public string Command { get; set; }
    }
}
