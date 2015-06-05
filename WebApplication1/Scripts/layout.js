
$(document).ready(function () {

    //clicar nas aulas no index
   $("#aulas").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center tipo-letra'></p>").text("Preparado?");
        var txt2 = $("<p class='text-center tipo-letra'></p>").text("Vamos lá aprender a geografia de Portugal!");
        var txt3 = $("<button type='button' id='aulas_button' class='btn btn-success'>Começar</button>");
        $(".index-click").append(txt1, txt2, txt3);
        $('#aulas_button').click(function () {
            window.location =  '../Home/Aulas';
        });
   });

    //clicar nos testes no index
    $("#testes").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center tipo-letra'></p>").text("Momento da Verdade");
        var txt2 = $("<p class='text-center tipo-letra'></p>").text("Testa os teus conhecimentos!");
        var txt3 = $("<button type='button' id='testes_button' class='btn btn-success' >Começar</button>");
        $(".index-click").append(txt1, txt2, txt3);
        $('#testes_button').click(function () {
            window.location = '../Home/Testes';
        });
    });

    //clicar na classificacao no index
    $("#classificacao").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center tipo-letra'></p>").text("Vê como te tens safado");
        var txt2 = $("<p class='text-center tipo-letra'></p>").text("E mostra aos teus amigos!");
        var txt3 = $("<button type='button' id='ranking_button' class='btn btn-success' >Ver</button>");
        $(".index-click").append(txt1, txt2, txt3);
        $('#ranking_button').click(function () {
            window.location = '../Home/Ranking';
        });
    });

   

});

