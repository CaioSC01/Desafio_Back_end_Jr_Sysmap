//função!
function arredondamento(array) {
  const number = array.map((n) => Math.floor(n));
  console.log(number);
}

//para testar basta descomentar as linha abaixo

function main() {
  var numeros = [1.2, 2.8, 3, 4.4, 5, 6.4, 17.8];
  arredondamento(numeros);
}

main();
