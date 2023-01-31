function somaDeArrays(array) {
  if (array.length < 5) {
    return console.log("Array tem menos de 5 elementos");
  }

  var quinto = array[4];
  var isPrimo = true;
  if (quinto <= 1) isPrimo = false;
  for (var i = 2; i < quinto; i++) {
    if (quinto % i === 0) {
      isPrimo = false;
      break;
    }
  }

  if (isPrimo) {
    array.splice(4, 1);
    console.log("Quinto elemento primo removido");

    var sum = 0;
    for (var i = 0; i < array.length; i++) {
      sum += array[i];
    }
    console.log("Soma dos elementos do array:", sum);
  } else {
    var newArray = [];
    for (var i = 0; i < 20; i++) {
      var newNumber = Math.floor(Math.random() * 100) + 1;
      var isPrime = true;
      if (newNumber <= 1) isPrime = false;
      for (var j = 2; j < newNumber; j++) {
        if (newNumber % j === 0) {
          isPrime = false;
          break;
        }
      }
      if (isPrime) newArray.push(newNumber);
      else i--;
    }
    console.log("Quinto elemento não era primo, gerando novo array:");

    var sum = 0;
    for (var i = 0; i < newArray.length; i++) {
      sum += newArray[i];
    }
    console.log(newArray);
    console.log("Soma dos elementos do array:", sum);
  }
}

//para testar basta descomentar as linha abaixo

function main() {
  var numeros = [1, 2, 3, 4, 6, 6];
  var teste = somaDeArrays(numeros);
  console.log(teste);
}

main();
