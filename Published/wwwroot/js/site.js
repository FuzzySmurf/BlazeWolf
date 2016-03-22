/* Site.js */
(function () {
    var main = $("#main");
    main.on("mouseenter", function() {
        main.style["background-color"] = "#888";
    });
    main.on("mouseleave", function() {
        main.style["background-color"] = "";
    });
})();