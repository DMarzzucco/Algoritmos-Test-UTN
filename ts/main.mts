// Fibonacci
const Limit: number = 20;
let N1: number = 0;
let N2: number = 1;

console.log(N1);
console.log(N2);

for (let i: number = N1 + N2; i < Limit; i = N1 + N2) {
    console.log(i);
    N1 = N2;
    N2 = i;
}

// tipos
type Color = `#${string}`
const rojo: Color = '#ff0000';
// array
const arreglo: Array<string | number>[] = [
    [1, 3, 4, 5],
    [1, 2, 3, 4],
    ["meme", 2, 3, 4,]
]
arreglo.push(['hola', 'mundo']);

// duplas
type RGB = [number | string, number | string, number | string];

const black: RGB = ["0s", 0, 0];

// enumeraciones -->(Enums)
const enum ERROR_TYPES {
    /* solo es habil utilizar el "CONST"
     cuando se usa en la aplicacion en si,
      en el cso de ser un componente reutilizable,
       es preferible usar el enum solo */
    NO_ENCONTRADO = "No encontrado",
    CREADO = "ya fue creado",
    ACTUALIZADO = "ya fue actualizado"
}

function colore(tipoDeError: ERROR_TYPES) {
    if (tipoDeError === ERROR_TYPES.NO_ENCONTRADO) {
        // console.log('Nose encuentra el recurso')
    } else if (tipoDeError === ERROR_TYPES.CREADO) {
        // console.log('El recurso fue creado')
    } else if (tipoDeError === ERROR_TYPES.ACTUALIZADO) {
        // console.log('El recurso fue actualizado')
    }
}
// aserciones de tipos
const canvas = document.querySelector('canvas')

if (canvas instanceof HTMLCanvasElement) {
    const ctx = canvas.getContext('2d')
}
// interfaces
interface Producto {
    id: number;
    nombre: string;
    precio: number;
}
interface zapatilla extends Producto {
    talla: number
}
interface CarrosdeCompra {
    total: number;
    productos: (Producto | zapatilla)[];
}
interface CarritoOps {
    add: (producto: Producto) => void;
    remove: (id: number) => void;
    update: (id: number, producto: Producto) => void;
}
const carrito: CarrosdeCompra = {
    total: 0,
    productos: [
        {
            id: 1,
            nombre: "mesa",
            precio: 100,
            talla: 40
        }
    ]
}

// Narrowing

function mostrarLongitud(objeto: number | string) {
    if (typeof objeto === 'string') {
        return objeto.length;
    }
    return objeto.toString().length
}

mostrarLongitud(1);

/*segundo ejemplo */
interface Mario {
    // company: 'nintendo',
    nombre: string,
    saltar: () => void
}

interface Sonic {
    // company: 'Sega',
    nombre: string,
    correr: () => void
}

type Personaje = Mario | Sonic;

// function Jugar(personaje: Personaje) {
//     if (personaje.company === 'nintendo') {
//         personaje.saltar();
//         return
//     }
//     personaje.correr();
// }

/*type Guard -> Hay que evitarlo... */
function check_Run(personaje: Personaje): personaje is Sonic {
    return (personaje as Sonic).correr !== undefined
}

function jugar(personaje: Personaje) {
    if (check_Run(personaje)) {
        personaje.correr();
        return
    }
    else if (!check_Run(personaje)) {
        personaje.saltar();
        return
    }

}
jugar(
    {
        nombre: 'mario',
        saltar: () => console.log('saltando')
    }
)


// clases
class Avanger {
    name: string
    power: number
    wonBattle: number = 0

    constructor(name: string, power: number) {
        this.name = name;
        this.power = power;
    }

    get fullName() {
        return `${this.name}, de poder ${this.power}`
    }

    set Set_power(newPower: number) {
        if (newPower <= 100) {
            this.power = newPower
        } else {
            throw new Error('El poder no puede ser mayor a 100')
        }
    }
}

const avangers = new Avanger('Iron Man', 100);
avangers.Set_power = 200;