Blazor.registerFunction("KendoUI.Interop.Widget.Dispose", (id) => {
    kendo.destroy(document.getElementById(id));
});
