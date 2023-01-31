//função!
function removendoObjeto(obj_json) {
  for (let i = 0; i < obj_json.length; i++) {
    let array = obj_json[i];
    if (array.hasOwnProperty("cidade") && array.cidade == "São Paulo") {
      console.log(array, i);
      obj_json.splice(i, 1);
      i--;
    }
  }
  console.log(obj_json);
  return obj_json;
}

//para testar basta descomentar as linha abaixo

// function main() {
//   fetch("js/json.json")
//     .then((response) => response.json())
//     .then((data) => {
//       removendoObjeto(data);
//     });
// }

// main();

//funçoes
