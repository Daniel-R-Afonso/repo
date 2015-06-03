
$(document).ready(function () {
    $(".menu").mouseover(function () {
        $("#menu-2-1").empty();
        $("#menu-2-1").text("cenas!");
    });
    $(".menu").click(function () {
        $("#menu-2-1").text("Hello world!");
    });
});
