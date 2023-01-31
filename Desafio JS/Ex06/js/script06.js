//função!
function Retorna_Pares(array) {
  return array.filter(function (num) {
    return num % 2 === 0;
  });
}

//para testar basta descomentar as linha abaixo

			// function main() {
			//   var numeros = [1, 2, 3, 4, 5, 6];
			//   var teste = Retorna_Pares(numeros);
			//   console.log(teste);
			// }

			// main();
