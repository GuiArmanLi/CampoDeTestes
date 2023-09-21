// Bloco de Gerar Senha
btnPassword = document.getElementById("btnPassword");
newPassword = document.getElementById("newPassword");
copyPassword = document.getElementById("copy");

contentSenha = document.getElementById("content-senha");
let copySenha;

btnPassword.addEventListener("click", () => {
    let base = gerarBaseDaSenha();
    let senhaGerada = gerarSenha(base);

    if (senhaGerada !== "") {
        contentSenha.style = "display:block";
        newPassword.innerHTML = senhaGerada;
        copySenha = senhaGerada;
    }
})

copyPassword.addEventListener("click", () => {
    navigator.clipboard.writeText(copySenha)
})

function gerarBaseDaSenha() {
    const baseDaSenha = ["abcdefghijklmnopqrstuvwxyz"];

    let checkMaiusc = document.getElementById("maiuscula");
    let checkNum = document.getElementById("numeros");
    let checkCharEspec = document.getElementById("charEspec");

    if (checkMaiusc.checked) { baseDaSenha.push("ABCDEFGHIJKLMNOPQRSTUVWXYZ") }
    if (checkNum.checked) { baseDaSenha.push("0123456789") }
    if (checkCharEspec.checked) { baseDaSenha.push("!@#$%^&*?") }

    return base = baseDaSenha.join("");
}

function gerarSenha(baseDaSenha) {
    let tamanhoDaSenha = document.getElementById("tamanhoDaSenha");
    try {

        let sorteio = "";

        for (i = 0; i < tamanhoDaSenha.value; i++) {
            console.log(sorteio)
            randomNumber = Math.floor(Math.random() * (baseDaSenha.length));
            sorteio += baseDaSenha[randomNumber];
        }
        return sorteio;
    } catch (error) {
        alert(error);
    } finally {
        tamanhoDaSenha.value = "";
    }
}