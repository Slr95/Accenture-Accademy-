export class Persona {
    nombre: string;
    apellido: string;
    edad: number;
    kilometros: number;
    //identado de codigo : alt + shift + f

    caminar() {
        console.log('estoy caminando ' + this.kilometros + 'por semana');
    }

    constructor(Kilometros: number){
        this.kilometros = Kilometros;
    }
}