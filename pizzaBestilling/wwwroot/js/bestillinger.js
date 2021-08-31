$(function () {
    $.get("pizza/HentAlle", function (bestillinger) {
        formaterBestillinger(bestillinger);
    });
});

function formaterBestillinger(bestillinger) {
    let ut = "<table class="table table-striped">" +
        "<tr>" +
        "<th>Navn</th><th>Adresse</th><th>Telefonnr</th>PizzaType</th>" +
        "<th>Tykkelse</th><th>Antall</th>" 
}