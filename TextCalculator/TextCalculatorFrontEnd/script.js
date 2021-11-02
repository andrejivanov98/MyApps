
document.getElementById("calculateBtn").addEventListener("click", function() {
    let inputField = document.getElementById("inlineFormInputName").value;  
    document.getElementById("error").innerHTML = "";
   
    fetch("https://localhost:44330/api/textcalculator/add/"+ inputField)
    .then(async response => {
        if (!response.ok)
            throw new Error(await response.text());
    
        return response;
    })
    .then(response => response.json())
    .then(result => {
        document.getElementById("result").innerHTML = result;
        
    })
    .catch(err => {
        document.getElementById("error").innerHTML = err.message;
        console.log(err.message)
    });
    
  });