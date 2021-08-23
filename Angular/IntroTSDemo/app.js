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
var foo = { bar: 123 };
foo.bar = 456; //PERMITIDO!
console.log(foo);
//Tipos de datos primitivos
//Boolean 
var isDone = true;
console.log('isDone: ' + isDone);
//Number
var decimal = 6;
console.log('decimal ' + decimal);
var hex = 0xf00d;
console.log('hexa ' + hex);
var binary = 01010;
console.log('binary ' + binary);
var octal = 484;
console.log('octal ' + octal);
//String : cadenas de caracteres y/o textos
var color = "blue";
console.log(color);
color = 'red';
console.log(color);
//tambien podemos concatenar utilizando templates
var fullName = "Evelyn Barahona";
var age = 27;
var sentence = "Hello, my name is " + fullName + ". I'll be " + (age + 1) + " years old next month";
console.log(sentence);
//Este tipo de sintaxis es el equivalente a : 
var sentence2 = "Hello , my name is " + fullName + ". I'll be " + (age + 1) + " years old next month";
console.log(sentence2);
