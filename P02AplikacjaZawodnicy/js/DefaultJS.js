


$(document).ready(function () {


    $("#dvLupka").click(function () {
        var n = parseInt($("#txtStrona").val());
        zapytanieNaServer(n);
    });

    $("#btnLewo").click(function () {
       var n= parseInt($("#txtStrona").val());
        n--;
        $("#txtStrona").val(n);
        zapytanieNaServer(n);
    });

    $("#btnPrawo").click(function () {
        var n = parseInt($("#txtStrona").val());
        n++;
        $("#txtStrona").val(n);
        zapytanieNaServer(n);
    });


});


function zapytanieNaServer(n) {
    $("table").hide();
    $("#dvLadowanie").show();

    /* $("#spWynik").html("ala ma kota");*/

    var filtr = $("#txtFiltr").val();


    $.ajax({
        method: "POST",
        url: "DefaultServer.aspx",
        data: { filtr: filtr, numerStrony: n, wielkoscStrony:5  }
    })
        .done(function (msg) {
            // debugger

            // msg to są zawodnicy sformatowani do formatu JSON i teraz
            // musimy sparsować JSONA (czyli przekonwertować do tablicy obiektu ale tym  raz w javascipt )
            var zawodnicy = JSON.parse(msg);
            var napis = "";
            for (var i = 0; i < zawodnicy.length; i++) {
                napis += "<tr>" +
                    "<td><a href='SzczegolyView.aspx?id=" + zawodnicy[i].Id_zawodnika + "'>" + zawodnicy[i].ImieNazwisko +"</a></td>"+
                  /*  "<td>" + zawodnicy[i].ImieNazwisko + "</td>" +*/
                    "<td>" + zawodnicy[i].Kraj + "</td>" +
                    "<td>" + zawodnicy[i].Wzrost + "</td>" +
                    "<td>" + zawodnicy[i].Waga + "</td>" +
                    "<td>" + new Date(parseInt(zawodnicy[i].DataUrodzenia.substring(6))).toLocaleDateString("pl-pl") + "</td>" + "</tr>";
            }

            $("table tbody").html(napis)

            $("table").show();
            $("#dvLadowanie").hide();
        });

}