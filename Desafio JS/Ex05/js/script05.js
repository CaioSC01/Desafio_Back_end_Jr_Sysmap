//função!
function ordenacaoDeObjetos(obj_json) {
  let array = obj_json;

  return array.sort(function (a, b) {
    var verific_first = a.NomeDoObjeto.toUpperCase();
    var verific_second = b.NomeDoObjeto.toUpperCase();
    if (verific_first < verific_second) {
      return -1;
    }
    if (verific_first > verific_second) {
      return 1;
    }
    return 0;
  });
}

//para testar basta descomentar as linha abaixo

// function main() {
//   fetch("js/json.json")
//     .then((response) => response.json())
//     .then((data) => {
//       var teste = ordenacaoDeObjetos(data);
//       console.log(teste);
//     });
// }

// main();


