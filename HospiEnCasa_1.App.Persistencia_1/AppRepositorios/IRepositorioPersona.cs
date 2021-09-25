using System.Collections.Generic;
using HospiEnCasa_1.App.Dominio_1;


namespace HospiEnCasa_1.App.Persistencia_1
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPacientes();
        Persona AddPersona (Persona persona);
        void DeletePersona (int idPersona);
        Persona GetPersona (int idPersona);
        Persona UpdatePersona(Persona persona);

    }
}