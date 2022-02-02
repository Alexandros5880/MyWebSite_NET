$(document).ready(function () {

    $(".link").hover(function () {
        var polygon = $(this).children().children().children();
        var text = polygon.children();
        polygon.attr("fill-opacity", "0.4");
    }, function () {
        var polygon = $(this).children().children().children();
        var text = polygon.children();
        polygon.attr("fill-opacity", "1");
    });

});