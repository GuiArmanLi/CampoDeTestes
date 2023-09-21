let pessoas = [];

let nome = document.getElementById("nome");
let idade = document.getElementById("idade");
let endereco = document.getElementById("endereco");

nome.addEventListener("onchange", () => {
    nome.style.backgroundColor = "red";
    idade.style.backgroundColor = "red";
    endereco.style.backgroundColor = "red";
})

postPessoa = document.getElementById("botao");

postPessoa.addEventListener("click", (nome, idade, endereco)=>{
    alert("Ola Ceta");
    let nome = this.nome.value;
    let idade = this.idade.value;
    let endereco = this.endereco.value;
    
    pessoa = { nome, idade, endereco }
    pessoas.push(pessoa);
})