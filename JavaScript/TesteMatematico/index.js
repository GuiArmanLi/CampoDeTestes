const contentDesafio = document.getElementById("contentDesafio");
const desafio = document.getElementById("desafio");

const inputResposta = document.getElementById("inputResposta");

const resultado = document.getElementById("resultado");

const imagem = document.getElementById("imagem");

const botao = document.getElementById("botao");

const desafios = ["5 + 4 -1 -3 + 2", //Resultado 7
    "8 * 7 + 58 / 2", // Resultado 85
    "((90 + 5) * 3 - 5) / 5", // Resultado 56
    "2 ^ 3 + (5 + 3) / 2" //Resultado 5
];
const mensagensDosDesafios = [
    "Fique atento a essa pessoa, ela pode representar uma ameaça!",
    "Esse indivíduo sofre de problemas mentais. Ao o ver na rua, atravesse!",
    "Troca de namorada igual toma banho. Há evidências que tudo é devido a sua esquizofrenia!",
    "Distância, pessoa é conhecida por ser perigosa.!"
];

let score = 0;
let primeiraVez = true;

botao.addEventListener("click", () => {
    if (primeiraVez === true) {
        primeiraVez = false;

        document.getElementById("introducao").style.display = "none";
        botao.innerHTML = "Enviar Resposta"

        exibirDesafio();
        ProximoDesafio();
    } else {
        verificarResultado();
    }
})

function verificarResultado() {
    let res = Number(inputResposta.value)
    try {
        console.log(score)
        if (botao.innerHTML == "Enviar Resposta") {
            if (
                score === 0 && res === 7 ||
                score === 1 && res === 85 ||
                score === 2 && res === 56 ||
                score === 3 && res === 5) {
                respostaCerta()

                botao.innerHTML = "Próximo";
            } else {
                alert("Resposta Incorreta")
                return;
            }
        } else if (botao.innerHTML == "Próximo") {
            exibirDesafio()
            ocultarResultado()

            ProximoDesafio()
        }
    } catch (error) {
        alert(error);
    } finally {
        inputResposta.value = "";
    }
}

function respostaCerta() {
    ocultarDesafio()
    exibirResultado()

    resultado.innerHTML = mensagensDosDesafios[score];
    imagem.src = `./imagens/${score}.jpg`
    score++
}

function ProximoDesafio() {
    if (score < 4) {
        botao.innerHTML = "Enviar Resposta";
        desafio.innerHTML = desafios[score]
    } else {
        score = 0;
        primeiraVez = true

        alert("Parabéns, fez nada mais que o necessário, sabe matemática básica!")

        ocultarDesafio()
        ocultarResultado()
        document.getElementById("introducao").style.display = "block";
    }
}

function exibirDesafio() {
    contentDesafio.style.display = "flex";
}
function exibirResultado() {
    resultado.style.display = "block";
    imagem.style.display = "block";
}

function ocultarDesafio() {
    contentDesafio.style.display = "none";
}
function ocultarResultado() {
    resultado.style.display = "none";
    imagem.style.display = "none";
}