// Bloco de Gerar Senha
buttonSenha = document.getElementById("buttonSenha");

buttonSenha.addEventListener("click", () => {
    let baseDaSenha = gerarBasedaSenha();
    let senhaFinal = sortear(baseDaSenha);

    return senhaFinal;
})

function gerarBasedaSenha() {
    const baseDaSenha = ["abcdefghijklmnopqrstuvwxyz"];

    let checkMaiuscula = document.getElementById("Maiuscula");
    let checkNumeros = document.getElementById("Numeros");
    let checkCaractereEspecial = document.getElementById("CaractereEspecial");

    if (checkMaiuscula.checked) { baseDaSenha.push("ABCDEFGHIJKLMNOPQRSTUVWXYZ") }
    if (checkNumeros.checked) { baseDaSenha.push("0123456789") }
    if (checkCaractereEspecial.checked) { baseDaSenha.push("!@#$%^&*?") }

    return baseDaSenha.join("");
}

function sortear(baseDaSenha) {
    let tamanhoDaSenha = document.getElementById("tamanhoDaSenha");
    let sorteio = "";

    for (i = 0; i < tamanhoDaSenha.value; i++) {
        randomNumber = Math.floor(Math.random() * (baseDaSenha.length));
        sorteio += baseDaSenha[randomNumber];
    }

    campoDeSenha = document.getElementById("senhaGerada");
    campoDeSenha.innerHTML = sorteio;
    campoDeSenha.style = "display:block;"

}

// Calculadora
let calculadora = document.getElementById("calculadora");

calculadora.onload(gerarCalculadora())


function gerarCalculadora(){

}