const user = {
  name: "Roberto",
  idade: "33",
  formado: "Sim",
  escolaridade: {
    instituicao1:
      "UNIVERSIDADE MG, UNIVERSIDADE SP, UNIVERSIDADE PR, UNIVERSADE RS",
    instituicao2: "Preencher essa informação",
  },
};

function updateUser(obj_user) {
  user.escolaridade.instituicao1 = user.escolaridade.instituicao1.split(", ");
  user.endereço = "Rua X, 77,Cotia/Sp";
  user.nacionalidade = "Brasileiro";
  user.situaçãoDoCurso = "Concluída";
  console.log(obj_user);
}

updateUser(user);

//  11.1 Crie uma função que receba o objeto e altere propriedade instituição 1 para um array de strings utilizando o separador virgula utilizando o valor da propriedade e adicione nessa array

// 11.2 Adicione 3 novas propriedade no objeto user endereço, nacionalidade e situação do curso.
