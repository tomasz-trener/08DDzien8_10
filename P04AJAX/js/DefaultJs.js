
$(document).ready(function () {

    $("#btnPrzyciskHTML").click(function () {

       /* $("#spWynik").html("ala ma kota");*/
        $.ajax({
            method: "POST",
            url: "DefaultServer.aspx",
            data: { name: "John", location: "Boston" }
        })
            .done(function (msg) {
               // debugger

                //alert(msg);
                $("#spWynik").html(msg)
            });

    });


});
