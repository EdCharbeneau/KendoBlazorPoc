if (!window.KendoUI) {
    window.KendoUI = {};
}

if (!window.KendoUI.Interop) {
    window.KendoUI.Interop = {};
}

window.KendoUI.Interop.Widget = {
    Dispose: (element) => {
        kendo.destroy(element);
    }
};

