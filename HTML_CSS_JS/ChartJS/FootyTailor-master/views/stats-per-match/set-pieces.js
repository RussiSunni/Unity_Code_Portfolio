var ctx = $("#canvas-1");

var myBarChart = new Chart(ctx, {
    type: 'bar',
    data:
    {
        labels: ["Corners", "Free Kicks", "Penalties", "Fouls Conceded"],
        datasets:
            [{
                label: '',
                data: [1, 2, 1, 4],
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