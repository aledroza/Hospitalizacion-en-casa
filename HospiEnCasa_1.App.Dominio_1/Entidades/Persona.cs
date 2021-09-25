using System;


namespace HospiEnCasa_1.App.Dominio_1
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        public Genero Genero {set; get;}
    }
}