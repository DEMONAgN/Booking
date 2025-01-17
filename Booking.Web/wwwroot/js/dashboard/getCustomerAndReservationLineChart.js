﻿
$(document).ready(function () {
    loadCustomerAndReservationLineChart();
});

function loadCustomerAndReservationLineChart() {
    $(".chart-spinner").show();

    $.ajax({
        url: "/Dashboard/GetMemberAndReservationLineChartData",
        type: 'GET',
        dataType: 'json',
        success: function (data) {

            loadLineChart("newMembersAndReservationsLineChart", data);

            $(".chart-spinner").hide();
        }
    });
}

function loadLineChart(id, data) {
    var chartColors = getChartColorsArray(id);
    var options = {
        colors: chartColors,
        chart: {
            height: 350,
            //show area later
            type: 'line',
            zoom: {
                type: 'x',
                enabled: true,
                autoScaleYaxis: true
            },
        },
        stroke: {
            curve: 'smooth',
            width: 2
        },
        series: data.series,
        dataLabels: {
            enabled: false,
        },
        markers: {
            size: 6,
            strokeWidth: 0,
            hover: {
                size: 9
            }
        },
        xaxis: {
            categories: data.categories,
            labels: {
                style: {
                    colors: "#fff",
                },
            }
        },
        yaxis: {
            labels: {
                //formatter: function (val) {
                //    return val.toFixed(0);
                //},
                style: {
                    colors: "#fff",
                },
            }
        },
        legend: {
            labels: {
                colors: "#fff",
            },
        },
        tooltip: {
            theme: 'dark'
        }
    };
    var chart = new ApexCharts(document.querySelector("#" + id), options);
    chart.render();
}