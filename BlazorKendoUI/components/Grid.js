Blazor.registerFunction("KendoUI.Interop.Grid.Init", (model) => {
    var id = model.id;
    var element = document.getElementById(id);

    model.dataSource = {
        data: model.data
    };

    model.editable = "popup";
    model.selectable = true;

    model.beforeEdit = function(e) { raiseEvent(id, 'GridBeforeEdit'); };
    model.change = function(e) { raiseEvent(id, 'GridChange'); };

    $(element).kendoGrid(model);

    return true;
});

Blazor.registerFunction("KendoUI.Interop.Grid.Update", (model) => {
    var id = model.id;
    var element = document.getElementById(id);

    model.dataSource = {
        data: model.data
    };

    var instance = kendo.widgetInstance($(element));

    if (instance) {
        instance.setOptions(model);
    }

    return true;
});

function raiseEvent(id, eventName) {
    return Blazor.invokeDotNetMethod({
        type: {
            assembly: 'BlazorKendoUI',
            name: 'BlazorKendoUI.KendoUIInterop'
        },
        method: {
            name: 'TriggerEvent'
        }
    }, id, eventName);
}
