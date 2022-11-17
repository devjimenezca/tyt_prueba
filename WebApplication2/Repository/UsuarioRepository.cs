using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;
using WebApplication2.Domain;
using WebApplication2.Persistence;

namespace WebApplication2.Repository
{
    public class UsuarioRepository
    {
       protected readonly DataDbContext _context;


        public  async Task<Usuario?> GetClienteByIdent(string identificacion)
        {
            return await _context!.Usuario!.Where(o => o.Identificacion == identificacion).FirstOrDefaultAsync();
        }

        public async Task<List<Usuario>> GetClienteAll()
        {
            return await _context!.Usuario!.ToListAsync();

        }

        public async Task<Usuario> SaveUsuario(Usuario usuario)
        {
            _context.Set<Usuario>().Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;

        }

        public async Task<Usuario> UpdateUsuario(Usuario usuario)
        {
            var entidad = _context.Usuario.Where(d => d.Id == usuario.Id).First();
            entidad.UsuarioName = usuario.UsuarioName;
            _context.SaveChanges();
            return usuario;

        }

        public async Task<Boolean> DeleteUsuario(int idUsuario)
        {
            var entidad = _context!.Usuario!.Single(x => x.Id == idUsuario);
            entidad.Estado = false;
            _context.SaveChanges();
            return true;

        }
    }
}
