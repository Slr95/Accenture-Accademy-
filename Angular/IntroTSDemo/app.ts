import { Persona } from "./Persona";

var miObjeto = new Persona(100);
miObjeto.caminar();










console.log('Hola mundo TS');

// alert('pasamos por aqui');

// LET, VAR Y CONST

//var: no tiene un ambito de bloque

//var foo = 123;
//if(true){
//    var foo = 456;
//}
//console.log(foo); // 456

//let: posee un ambito de bloque
//let foo2 = 123;
//if(true){
//    let foo2 = 456;
//}
//console.log('foo2:'+foo2); // 123

// Constantes : 
//const fue añadido en ES6 
//las constantes deben ser declaradas y asignadas SIEMPRE!
//const foo = 123;
//console.log(foo);

// foo = 456; NO HACERLO ERROR!

//las constantes admiten objetos literales como por ej:
//const foo = { bar : 123};
//foo = {bar : 456}; //Error no se permite la modificacion de objeto

//pero si se puede modificar el contenido de las variables que contiene el 
//objeto literal
const foo = {bar : 123};
foo.bar = 456; //PERMITIDO!
console.log(foo);

//Tipos de datos primitivos

//Boolean 
let isDone: boolean = true;
console.log('isDone: ' + isDone);

//Number
let decimal: number = 6;
console.log('decimal ' + decimal);

let hex: number = 0xf00d;
console.log('hexa ' + hex);

let binary: number = 01010;
console.log('binary ' + binary);

let octal: number = 0o744;
console.log('octal ' + octal);

//String : cadenas de caracteres y/o textos

let color : string = "blue";
console.log(color);
color = 'red';
console.log(color);

//tambien podemos concatenar utilizando templates

let fullName: string = `Evelyn Barahona`;
let age: number = 27;
let sentence: string = `Hello, my name is ${ fullName }. I'll be ${ age + 1} years old next month`;

console.log(sentence);

//Este tipo de sintaxis es el equivalente a : 
let sentence2: string = "Hello , my name is " + fullName + ". I'll be " + (age + 1) + " years old next month";
console.log(sentence2);


let cualquierDato:ObjetoMorty = {
    "id": 10,
    "name": "Alan Rails",
    "status": "Dead",
    "species": "Human",
    "type": "Superhuman (Ghost trains summoner)",
    "gender": "Male",
}; 


export interface ObjetoMorty {
    id: number;
    name: string;
    status: string;
    species: string;
    type: string;
    gender: string;
}
