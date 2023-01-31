function VerificacaoDePropriedades(obj_json) {
  for (let i = 0; i < obj_json.length; i++) {
    let array = obj_json[i];
    if (array.hasOwnProperty("cidade") && array.cidade == "Belo Horizonte") {
      array.estado = "MG";
    }
    console.log(array);
    return array;
  }
}
//para testar basta descomentar as linha abaixo

// function main() {
//   fetch("js/json.json")
//     .then((response) => response.json())
//     .then((data) => {
//       VerificacaoDePropriedades(data);
//     });
// }

// main();
