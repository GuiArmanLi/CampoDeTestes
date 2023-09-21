let btn = document.getElementById("btn");
let res = document.getElementById("res");

let pessoas = [];

btn.addEventListener("click", () => {
    let nome = document.getElementById("nome").value;
    let idade = document.getElementById("idade").value;
    let endereco = document.getElementById("endereco").value;

    let pessoa = { nome, idade, endereco }

    pessoas.push(pessoa);

    res.innerHTML = "";
    "<ul>"
    for (i = 0; i < pessoas.length; i++) {
        res.innerHTML += `<li>Nome: ${pessoas[i].nome}, idade: ${pessoas[i].idade}, endereço ${pessoas[i].endereco}</li>`
    }
    "</ul>"
    console.log(pessoas)
})