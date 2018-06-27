Blazor.registerFunction("KendoUI.Interop.Button.Init", (model) => {
    var id = model.id;
    var element = document.getElementById(id);

    $(`#${id}`).kendoButton({
        click: function() {
            var result = Blazor.invokeDotNetMethod({
                type: {
                    assembly: 'BlazorKendoUI',
                    name: 'BlazorKendoUI.KendoUIInterop'
                },
                method: {
                    name: 'TriggerEvent'
                }
            }, id, 'ButtonClicked');
        }
    });

    return true;
});
