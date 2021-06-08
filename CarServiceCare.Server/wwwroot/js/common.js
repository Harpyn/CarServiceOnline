window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Úspěch");
    }
    if (type === "error") {
        toastr.error(message, "Chyba");
    }
    if (type === "info") {
        toastr.info(message, "Info");
    }
    if (type === "warning") {
        toastr.warning(message, "Varování");
    }
}