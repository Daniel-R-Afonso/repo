
$(document).ready(function () {
    // ------------------------------ INDEX  ------------

    //clicar nas aulas no index
    $("#aulas").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center tipo-letra'></p>").text("Preparado?");
        var txt2 = $("<p class='text-center tipo-letra'></p>").text("Vamos lá aprender a geografia de Portugal!");
        var txt3 = $("<button type='button' id='aulas_button' class='btn btn-success'>Começar Aula</button>");
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
        var txt3 = $("<button type='button' id='testes_button' class='btn btn-success'>Começar Teste</button>");
        $(".index-click").append(txt1, txt2, txt3);
        $('#testes_button').click(function () {
            window.location = '../Perguntas/Testes';
        });
    });

    //clicar na classificacao no index
    $("#classificacao").click(function () {
        $(".index-click").empty();
        var txt1 = $("<p class='text-center tipo-letra'></p>").text("Estás no topo da tabela?");
        var txt2 = $("<p class='text-center tipo-letra'></p>").text("Mostra aos teus amigos!");
        var txt3 = $("<button type='button' id='ranking_button' class='btn btn-success' >Classificação</button>");
        $(".index-click").append(txt1, txt2, txt3);
        $('#ranking_button').click(function () {
            window.location = '../Utilizadores/Ranking';
        });
    });


    





});

