// Fibonacci
var limit = 20;
var n1 = 0;
var n2 = 1;
console.log(n1);
console.log(n2);
for (var i = n1 + n2; i < limit; i = n1 + n2) {
    console.log(i);
    n1 = n2;
    n2 = i;
}
// 
function AgePeople(age) {
    if (age >= 18) {
        console.log("You are an adult");
    } else {
        console.log("You are a minor");
    }
}

// year born 
var age = ('');
var born = 1998;

function yearBorn(year) {
    var year = new Date().getFullYear();
    var born = year - age;
    console.log("You were born in " + born);
}

yearBorn(18);
// 
var Yearborn = 1998;

function yearBorn(year) {
    var year = 2023;
    var age = year - Yearborn;
    console.log("You age is " + age);
}

yearBorn();

// 
function wordCount(text) {
    text = text.trim();
    var words = text.split(/\s+/);
    return words.length;
}

var texto = "ns ns";
console.log("Número de palabras:", wordCount(texto));

// 
function validarContraseña(contraseña) {
    // Verificar la longitud de la contraseña
    if (contraseña.length < 8) {
        return "La contraseña debe tener al menos 8 caracteres.";
    }
    // Verificar si la contraseña contiene al menos una letra mayúscula
    if (!/[A-Z]/.test(contraseña)) {
        return "La contraseña debe contener al menos una letra mayúscula.";
    }
    // Verificar si la contraseña contiene al menos un número
    if (!/\d/.test(contraseña)) {
        return "La contraseña debe contener al menos un número.";
    }
    // Si la contraseña pasa todas las validaciones, retornar true
    return true;
}
// Ejemplo de uso
var contraseña1 = "Abc12345"; // Válida
var contraseña2 = "abcde"; // No válida
console.log(validarContraseña(contraseña1)); // Salida esperada: true
// console.log(validarContraseña(contraseña2)); 

