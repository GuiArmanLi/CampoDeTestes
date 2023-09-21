buttonIdade = document.getElementById("buttonIdade");

buttonIdade.addEventListener("click", () => {

    let idade = document.getElementById("idade");
    let response = document.getElementById("response");
    "<ul>"
    for (i = 0; i <= idade.value; i++) {
        if (i < 15) {
            resposta = `<li>Essa pessoa tem ${i} anos. Uma criança.</li>`
        } else if (i >= 15 && i <= 26) {
            resposta = `<li>Essa pessoa tem ${i} anos. Um jovem.</li>`
        } else {
            resposta = `<li>Essa pessoa tem ${i} anos. Velho.</li>`
        }
        response.innerHTML += resposta;
    }
    "</ul>"
});