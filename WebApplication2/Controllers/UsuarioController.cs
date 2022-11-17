using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication2.Domain;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpGet(Name = "GetUsuario")]
        public async Task<List<Usuario>> Get()
        {
            UsuarioRepository _UsuarioRepository = new UsuarioRepository();
            return await _UsuarioRepository.GetClienteAll();
        }
        [HttpPost(Name = "SaveUsuario")]
        public async Task<Usuario> Post(Usuario usuario)
        {
            UsuarioRepository _UsuarioRepository = new UsuarioRepository();
            return await _UsuarioRepository.SaveUsuario(usuario);
        }
        [HttpPut(Name = "UpdateUsuario")]
        public async Task<Usuario> Put(Usuario usuario)
        {
            UsuarioRepository _UsuarioRepository = new UsuarioRepository();
            return await _UsuarioRepository.UpdateUsuario(usuario);
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public async Task<Boolean> Put(int Id)
        {
            UsuarioRepository _UsuarioRepository = new UsuarioRepository();
            return await _UsuarioRepository.DeleteUsuario(Id);
        }
    }
}