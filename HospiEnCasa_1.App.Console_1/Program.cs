using System;
using HospiEnCasa_1.App.Dominio_1;
using HospiEnCasa_1.App.Persistencia_1;

namespace HospiEnCasa_1.App.Console_1
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia_1.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework !Como tais!");
            //AddPersona();
            BuscarPersona(1);
        }

        private static void AddPersona()
        {
        ///<summary>Interaccion con la base de datos</summary>
            var persona =new Persona{
                Nombre = "Alexis",
                Apellidos = "Pedroza",
                NumeroTelefono = "3207813976",
                Genero = Genero.femenino

            };
            _repoPersona.AddPersona(persona);
        }

        // buscar persona
        private static void BuscarPersona(int idPersona)
        {
            var persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(persona.Nombre+" "+persona.Apellidos);

        }
    }
}
