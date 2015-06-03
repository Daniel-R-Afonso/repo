
$(document).ready(function () {
    $(".1").hover(function () {
        $("p").hide();
    });
    $(".menu-1").click(function () {
        $("#menu-2-1").text("Hello world!");
    });
});
