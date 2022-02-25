$(document).ready(function () {

    $(".link").hover(function () {
        var polygon = $(this).children().children().children();
        var text = polygon.children();
        polygon.attr("fill-opacity", "0.4");
        if (polygon.hasClass('link-white')) {
            polygon.attr("fill", "#17539B");
            text.attr("fill", "white");
        }
    }, function () {
        var polygon = $(this).children().children().children();
        var text = polygon.children();
        polygon.attr("fill-opacity", "1");
        if (polygon.hasClass('link-white')) {
            polygon.attr("fill", "none");
            text.attr("fill", "#17539B");
        }
    });

});