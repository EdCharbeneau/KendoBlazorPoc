if (!window.KendoUI) {
    window.KendoUI = {};
}

if (!window.KendoUI.Interop) {
    window.KendoUI.Interop = {};
}

window.KendoUI.Interop.Grid = {
    Init: (element, model, componentReference) => {
        model.dataSource = {
            data: model.data
        };

        model.editable = "popup";
        model.selectable = true;

        model.beforeEdit = function(sender) { raiseEvent(sender, 'GridBeforeEdit'); };
        model.change = function(sender) { raiseEvent(sender, 'GridChange'); };

        var grid = $(element).kendoGrid(model).data("kendoGrid");
        grid._componentRef = componentReference;

        return true;
    },
    Update: (element, model) => {
        model.dataSource = {
            data: model.data
        };

        var instance = kendo.widgetInstance($(element));

        if (instance) {
            instance.setOptions(model);
        }

        return true;
    }
};

function raiseEvent(sender, eventName) {
    sender._componentRef.invokeMethodAsync(eventName);
}
