import { Byte } from "@angular/compiler/src/util";

export interface Persona {

    Nombre:string;
    Apellidos:string;
    Direccion:string;
    FechaNacimiento:Date;
    Telefono:string;
    IdDepartamento:Number;
    Id:number;
    Foto:Byte[];

}
