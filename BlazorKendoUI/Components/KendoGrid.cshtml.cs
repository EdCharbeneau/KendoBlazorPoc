using BlazorKendoUI.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorKendoUI.Components
{
    public class KendoGridBase : KendoComponentBase
    {
        [Parameter]
        IEnumerable<object> Data { get; set; }

        [Parameter]
        bool Sortable { get; set; }

        [Parameter]
        List<GridColumn> Columns { get; set; }

        #region Events

        [Parameter]
        Action OnGridBeforeEdit { get; set; }
        [JSInvokable]
        public void GridBeforeEdit() => OnGridBeforeEdit?.Invoke();

        [Parameter]
        Action OnGridChange { get; set; }
        [JSInvokable]
        public void GridChange() => OnGridChange?.Invoke();

        #endregion

        #region Templates

        [Parameter]
        protected RenderFragment RowTemplate { get; set; }

        #endregion


        protected override Task OnParametersSetAsync()
        {
            UpdateGrid();

            return Task.CompletedTask;
        }

        public void UpdateGrid()
        {
            KendoUIInterop.Update(element, GetModel());
        }

        protected override ComponentModelBase GetModel()
        {
            return new GridModel
            {
                Data = this.Data,
                Columns = this.Columns,
                Sortable = this.Sortable
            };
        }
    }
}
