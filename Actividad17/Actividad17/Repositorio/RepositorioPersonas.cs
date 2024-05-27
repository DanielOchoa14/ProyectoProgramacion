using Actividad17.Data;
using Microsoft.EntityFrameworkCore;

namespace Actividad17.Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly DirectorioDBContext _context;

        public RepositorioPersonas(DirectorioDBContext context)
        {
            _context = context;
        }
        public async Task<Persona> Add(Persona persona)
        {
            await _context.Persona.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Persona.FindAsync(id);
            if(persona == null)
            {
                _context.Persona.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Persona?> Get(int id)
        {
            return await _context.Persona.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Persona.ToListAsync();
        }

        public async Task Update(int id, Persona persona)
        {
            var personaactual = await _context.Persona.FindAsync(id);
            if(personaactual != null)
            {
                personaactual.Nombre = persona.Nombre;
                personaactual.Correo = persona.Correo;
                personaactual.Telefono = persona.Telefono;
                personaactual.Direccion = persona.Direccion;
                await _context.SaveChangesAsync();
            }
        }
    }
}
