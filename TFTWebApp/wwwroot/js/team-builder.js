let popover;

function initPopovers() {
    popover = new bootstrap.Popover(document.getElementById("popover-trigger"))
}

function showPopover() {
    popover.show();
}

function hidePopover() {
    popover.hide();
}

