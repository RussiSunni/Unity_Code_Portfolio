var ctx = $("#canvas-1");

var myBarChart = new Chart(ctx, {
    type: 'pie',
    data:
    {
        labels: ["Your team", "Opponent"],
        datasets:
            [{
                label: '% possession',
                data: [60, 40],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                ],
                borderColor: [
                    'rgba(255,99,132,1)',
                    'rgba(54, 162, 235, 1)',
                ],
                borderWidth: 1
            }]
    }

});

var ctx = $("#canvas-2");

var myBarChart = new Chart(ctx, {
    type: 'bar',
    data:
    {
        labels: ["First", "Second", "Third", "Fourth"],
        datasets:
            [{
                label: '% possession',
                data: [50, 60, 30, 25],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)',
                ],
                borderColor: [
                    'rgba(255,99,132,1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                ],
                borderWidth: 1
            }]
    },
    options:
    {
        scales:
        {
            yAxes: [{
                ticks:
                {
                    beginAtZero: true
                }
            }]
        }
    }

});