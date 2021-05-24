function crearAlerta() {
    alert('Alerta desde archivo js');
}

function realizarSuma(n1, n2) {
    return "El resultado es: " + (n1 + n2);
}

function agregarTextoEnId(id, texto) {
    document.getElementById(id).innerText = texto;
}

function focusEnElemento(e) {
    e.focus();
}

function obtenerJson() {
    var objeto = {
        attr1: "Hola",
        attr2: "Mundo"
    };

    return objeto;
}

function mostrarJsonEnConsoleLog(json) {
    console.log(json)
}