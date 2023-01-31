function format(input_moeda) {
  const input = document.querySelector(`.${input_moeda}`);

  if (isNaN(input.value) || input.value == "") {
    console.log("não é valido");
  } else {
    var valor = parseInt(input.value);

    //com R$
    var a = valor.toLocaleString("pt-br", {
      style: "currency",
      currency: "BRL",
    });

    //sem R$
    var b = valor.toLocaleString("pt-br", { minimumFractionDigits: 2 });

    console.log(a);
    console.log(b);
  }
}
