using System.Collections.Generic;
using HospiEnCasa_1.App.Dominio_1;
using System.Linq;

namespace HospiEnCasa_1.App.Persistencia_1
{
    public class RepositorioPersona : IRepositorioPersona
    {
        /// <summary>
        /// Referencia al contexto de Persona
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor utiliza
        /// Inyeccion de depencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name ="appContext"></param>//
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            //throw new System.NotImplementedException();
            var personaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            //throw new System.NotImplementedException();
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrada == null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPacientes()
        {
            //throw new System.NotImplementedException();
            return _appContext.Personas;

        }
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            //throw new System.NotImplementedException();
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            //FirstOrDefault
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            throw new System.NotImplementedException();

            //var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            //if (personaEncontrada != null)
            //{
                //personaEncontrada.Nombre = persona.Nombre;
                //personaEncontrada.Apellidos = persona.Apellidos;
                //personaEncontrada.NumeroTelefono = persona.NumeroTelefono;
                //personaEncontrada.Genero = persona.Genero;

                //_appContext.SaveChanges();
                //return personaEncontrada;
            //}
        }




    }

}