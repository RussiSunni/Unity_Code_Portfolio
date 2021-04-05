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
        labels: ["player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1"],
        datasets:
            [{
                label: 'shots on target',
                data: [1, 0, 0, 2, 1, 3, 5, 2, 0, 1],
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

var ctx = $("#canvas-3");

var myBarChart = new Chart(ctx, {
    type: 'bar',
    data:
    {
        labels: ["player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1", "player 1"],
        datasets:
            [{
                label: 'shots off target',
                data: [1, 2, 0, 4, 4, 3, 6, 2, 7, 1],
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


var ctx = $("#canvas-4");

var myBarChart = new Chart(ctx, {
    type: 'pie',
    data:
    {
        labels: ["Direct", "Set piece", "Penalty"],
        datasets:
            [{
                label: '% possession',
                data: [2, 1, 0],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(54, 162, 235, 0.2)'
                ],
                borderColor: [
                    'rgba(255,99,132,1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(54, 162, 235, 1)'
                ],
                borderWidth: 1
            }]
    }

});