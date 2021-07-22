const navService = {
    searchInput: document.getElementById("countrySearchInput"),
    searchBtn: document.getElementById("countrySearchBtn"),
    registerNavListeners: function(){
        this.searchBtn.addEventListener("click", function(event){
            event.preventDefault();
            countryService.country = navService.searchInput.value;
            countryService.getData();
            navService.searchInput.value = "";
        })
    }
}

const countryService = {
    country: "Macedonia",
    apiUrl: "https://restcountries.eu/rest/v2/name/",
    getData: async function(){
        try{

        let data = await fetch(`${this.apiUrl}${this.country}`);
        let response = await data.json();
        uiService.printResults(await response);

    }

        catch{
            console.log("Error");

        }
    }
}

const uiService = {
     tableResult: document.getElementById("tableResult"),

     printResults: function(data){
        this.tableResult.innerHTML = "";
         data.forEach(country => {
             this.tableResult.innerHTML += `
             <tr>
             <th><img src="${country.flag}" height="35px"></th>
             <td>${country.name}</td>
             <td>${country.region}</td>
             <td>${country.population}</td>
             <td>${country.capital}</td>
             <td>${country.area}</td>
           </tr>
             `
         });
     }



}

navService.registerNavListeners();
countryService.getData();
