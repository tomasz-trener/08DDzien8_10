﻿$(document).ready(function () {
    // Javascript method's body can be found in assets/js/demos.js
    demo.initDashboardPageCharts();

    $.ajax({
        method: "POST",
        url: "WykresyServer.aspx",
        //data: { filtr: filtr }
    })
        .done(function (msg) {
            var daneDoWykresu = JSON.parse(msg);
            stworzWykresSlupkowy(daneDoWykresu);
        });
});


function stworzWykresSlupkowy(daneDoWykresu) {
   // ctx = document.getElementById('lineChartExampleWithNumbersAndGrid').getContext("2d");
    var e = document.getElementById("barChartSimpleGradientsNumbers").getContext("2d");

    gradientFill = e.createLinearGradient(0, 170, 0, 50);
    gradientFill.addColorStop(0, "rgba(128, 182, 244, 0)");
    gradientFill.addColorStop(1, hexToRGB('#2CA8FF', 0.6));


    var a = {
        type: "bar",
        data: {
            labels: daneDoWykresu.OsX,
            datasets: [{
                label: "Wzrost",
                backgroundColor: gradientFill,
                borderColor: "#2CA8FF",
                pointBorderColor: "#FFF",
                pointBackgroundColor: "#2CA8FF",
                pointBorderWidth: 2,
                pointHoverRadius: 4,
                pointHoverBorderWidth: 1,
                pointRadius: 4,
                fill: true,
                borderWidth: 1,
                data: daneDoWykresu.OsY
            }]
        },
        options: {
            maintainAspectRatio: false,
            legend: {
                display: false
            },
            tooltips: {
               // bodySpacing: 4,
              //  mode: "nearest",
              //  intersect: 0,
                //position: "nearest",
                //xPadding: 10,
                //yPadding: 10,
                //caretPadding: 10
            },
            responsive: 1,
            scales: {
                yAxes: [{
                    gridLines: 0,
                    gridLines: {
                        zeroLineColor: "transparent",
                        drawBorder: false
                    }
                }],
                xAxes: [{
                    display: 0,
                    gridLines: 0,
                    ticks: {
                        display: false
                    },
                    gridLines: {
                        zeroLineColor: "transparent",
                        drawTicks: false,
                        display: false,
                        drawBorder: false
                    }
                }]
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 15,
                    bottom: 15
                }
            }
        }
    };

    var viewsChart = new Chart(e, a);
}