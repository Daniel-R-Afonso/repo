
$(document).ready(function () {
 
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

    //cenas dos mapas

    cvi_map.defaultRadius = 0;	//INT 0-100 (px radius)
    cvi_map.defaultOpacity = 33; //INT 0-100 (% opacity)
    cvi_map.defaultBordercolor = '#0000ff'; //STR '#000000'-'#ffffff'
    cvi_map.defaultAreacolor = '#000000'; //STR '#000000'-'#ffffff'
    cvi_map.defaultNoborder = false; //BOOLEAN
    cvi_map.defaultNofade = false; //BOOLEAN
    cvi_map.defaultShowcoords = false; //BOOLEAN
    cvi_map.defaultDelayed = false;	//BOOLEAN
    cvi_map.defaultImgsrc = ''; //STR (path&file)
    cvi_map.defaultMapid = ''; //STR (id)

    cvi_map.add(document.getElementById("mapa_portugal"), { opacity: 25, areacolor: 'ff0000' });
});

