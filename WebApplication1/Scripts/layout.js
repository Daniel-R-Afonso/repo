
$(document).ready(function () {
    $("#aulas").mouseover(function () {
    });
    $(".menu").click(function () {
        $("#menu-2-1").text("Hello world!");

    });

    $("#aulas").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center'></p>").text("Preparado?");
        var txt2 = $("<p class='text-center'></p>").text("Vamos lá aprender a geografia de Portugal!");
        var txt3 = $("<button type='button' class='btn btn-success'>Começar</button>");
        $(".index-click").append(txt1,txt2,txt3);        
    });

    $("#testes").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center'></p>").text("Momento da Verdade");
        var txt2 = $("<p class='text-center'></p>").text("Testa os teus conhecimentos!");
        var txt3 = $("<button type='button' class='btn btn-success'>Começar</button>");
        $(".index-click").append(txt1, txt2,txt3);
    });

    $("#classificacao").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center'></p>").text("Vê como te tens safado");
        var txt2 = $("<p class='text-center'></p>").text("E mostra aos teus amigos!");
        var txt3 = $("<button type='button' class='btn btn-success'>Ver</button>");
        $(".index-click").append(txt1, txt2,txt3);
    });
});