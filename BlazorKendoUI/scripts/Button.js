if (!window.KendoUI) {
    window.KendoUI = {};
}

if (!window.KendoUI.Interop) {
    window.KendoUI.Interop = {};
}

window.KendoUI.Interop.Button = {
    Init:(element, model, componentReference) => {
        var componentRef = componentReference;

        $(element).kendoButton({
            click: function() {
                componentRef.invokeMethodAsync("ButtonClick");
            }
        });

        return true;
    }
};
