/* Site.js */
(function () {

    //var ele = document.getElementById("username");
    var ele = $("#username");
    ele.innerHTML = "test user";

    var main = $("#main");
    main.on("mouseenter", function() {
        main.style["background-color"] = "#888";
    });
    main.on("mouseleave", function() {
        main.style["background-color"] = "";
    });

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function() {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeclass("fa-angle-right");
            $icon.addclass("fa-angle-left");
        } else {
            $icon.removeclass("fa-angle-left");
            $icon.addclass("fa-angle-right");
        }
    });
})();