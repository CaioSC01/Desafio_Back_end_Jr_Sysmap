
//função!
function recebeJson(obj_json) {
 for(let propriedade in obj_json ){
	console.log(propriedade)
 }
}



//para testar basta descomentar as linha abaixo

function main() {
  fetch("js/json.json")
    .then((response) => response.json())
    .then((data) => {
      recebeJson(data);
    });
}

main();
