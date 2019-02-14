$(document).ready(function () {
    let countries = {};

    //fetches all countries and append as options
    fetch('https://restcountries.eu/rest/v2/all').then(response => response.json())
    .then(json_files => {
        let options = '';
        countries = json_files;
        for (let country of countries) {
            options += `<option value="${country.name}">${country.name}</option>`;    
        }
        $("#country").append(options);
    });
})