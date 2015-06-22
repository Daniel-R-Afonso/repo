
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

    // ---------------------- TESTES --------
    //Zona de testes
    var pos = 0, test, test_status, question, choice, choices, chA, chB, chC, correct = 0;

    $(".começa-teste").click(function () {
        $(".zona-butoes").empty();
        renderQuestion(); 
    });
    


    function _(x) {
        return document.getElementById(x);
    }
    
    function renderQuestion(){
        
        test = _("test");
        if(pos >= questions.length){
            test.innerHTML = "<h2>You got "+correct+" of "+questions.length+" questions correct</h2>";
            _("test_status").innerHTML = "Test Completed";
            pos = 0;
            correct = 0;
            return false;
        }

        _("test_status").innerHTML = "Question "+(pos+1)+" of "+questions.length;
        question = questions[pos][0];
        chA = questions[pos][1];
        chB = questions[pos][2];
        chC = questions[pos][3];
        test.innerHTML = "<h3>"+question+"</h3>";
        test.innerHTML += "<input type='radio' name='choices' value='A'> "+chA+"<br>";
        test.innerHTML += "<input type='radio' name='choices' value='B'> "+chB+"<br>";
        test.innerHTML += "<input type='radio' name='choices' value='C'> "+chC+"<br><br>";
        test.innerHTML += "<button type='button' id='prox'>Submit Answer</button>";
        $("#prox").click(function () {
            choices = document.getElementsByName("choices");
            for (var i = 0; i < choices.length; i++) {
                if (choices[i].checked) {
                    choice = choices[i].value;
                }
            }
            if (choice == questions[pos][4]) {
                correct++;
            }
            pos++;
            renderQuestion();
        });
    }
   


});

