//função!
function Retorna_Primos(array) {
  return array.filter(function (num) {
    if (num <= 1) {
      return false;
    }
    for (let i = 2; i < num; i++) {
      if (num % i === 0) {
        return false;
      }
    }
    return true;
  });
}

//para testar basta descomentar as linha abaixo

function main() {
  var numeros = [1, 2, 3, 4, 5, 6, 17];
  var teste = Retorna_Primos(numeros);
  console.log(teste);
}

main();
