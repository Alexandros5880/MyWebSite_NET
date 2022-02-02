



$(document).ready(function () {

    
    $(".nav-item").on("click", function () {
        //$("a").find(".active").removeClass("active");
        //$(this).children().addClass("active");
        //$(this).children().css("color", "green");
    });


    $("#down").css("display", "block");
    $("#up").css("display", "none");
    $(".navbar-toggler").click(function () {
        if ($('#navbarSupportedContent').is(':visible')) {
            $("#down").css("display", "block");
            $("#up").css("display", "none");
        } else {
            $("#down").css("display", "none");
            $("#up").css("display", "block");
        }
    });


});


