const navService = {
    allCharactersBtn: document.getElementById("allCharactersBtn"),
    studentsBtn: document.getElementById("studentsBtn"),
    staffBtn: document.getElementById("staffBtn"),
    refreshBtn: document.getElementById("refreshBtn"),
    registerNavListenersAllCharacters: function(){
            allCharactersService.getData();
    },
    registerNavListenersStudents: function(){
            studentsService.getData();
    },
    registerNavListenersStaff: function(){
            staffService.getData();
    },
    registerNavListenersRefresh: function(){
        uiService.tableResult.innerHTML = "";
}

}



const allCharactersService = {
    apiUrl: "http://hp-api.herokuapp.com/api/characters/",
    getData: async function(){
        try{
        let data = await fetch(`${this.apiUrl}`);
        let response = await data.json();
        uiService.printResults(await response);
        
    }
        catch{
            console.log("Error while presenting all characters happened!");

        }
    }
}

const studentsService = {
    apiUrl: "http://hp-api.herokuapp.com/api/characters/students",
    getData: async function(){
        try{
        let data = await fetch(`${this.apiUrl}`);
        let response = await data.json();
        uiService.printResults(await response);
        
    }
        catch{
            console.log("Error while presenting students happened!");

        }
    }
}

const staffService = {
    apiUrl: "http://hp-api.herokuapp.com/api/characters/staff",
    getData: async function(){
        try{
        let data = await fetch(`${this.apiUrl}`);
        let response = await data.json();
        uiService.printResults(await response);
        
    }
        catch{
            console.log("Error while presenting staff happened!");

        }
    }
}

const uiService = {
    tableResult: document.getElementById("tableResult"),

    printResults: function(data){
       this.tableResult.innerHTML = "";
        data.forEach(character => {
            this.tableResult.innerHTML += `
            <tr>
            <th><img src="${character.image}" height="110px"></th>
            <td>${character.name}</td>
            <td>${character.dateOfBirth}</td>
            <td>${character.gender}</td>
            <td>${character.house}</td>
            <td>${character.actor}</td>
          </tr>
            `
        });
    }



}

navService.allCharactersBtn.addEventListener("click", navService.registerNavListenersAllCharacters);
navService.studentsBtn.addEventListener("click", navService.registerNavListenersStudents);
navService.staffBtn.addEventListener("click", navService.registerNavListenersStaff);
navService.refreshBtn.addEventListener("click", navService.registerNavListenersRefresh);