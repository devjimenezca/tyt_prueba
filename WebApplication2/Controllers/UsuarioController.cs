using Microsoft.AspNetCore.Mvc;
using WebApplication2.Domain;
using WebApplication2.Domain.Common;
using WebApplication2.DTOs;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpGet(Name = "GetUsuario")]
        public async Task<ResponseModel> Get()
        {
            ResponseModel response = new ResponseModel();
            try
            {
          
                UsuarioRepository _UsuarioRepository = new UsuarioRepository();
                response.CodError = 0;
                response.Respuesta.Add( await _UsuarioRepository.GetClienteAll());
               
            }
            catch (Exception ex)
            {
                response.CodError = 999;
                response.Mensaje = ex.Message;
            }
            return response;

        }
        [HttpPost(Name = "SaveUsuario")]
        public async Task<ResponseModel> Post(UsuarioDTO usuario)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                UsuarioRepository _UsuarioRepository = new UsuarioRepository();
                response.CodError = 0;
                var resultado =  _UsuarioRepository.SaveUsuario(usuario);
                response.Respuesta.Add(resultado);
            }
            catch (Exception ex)
            {
                response.CodError = 999;
                response.Mensaje = ex.Message;
            }
            return response;

        }
        [HttpPut(Name = "UpdateUsuario")]
        public async Task<ResponseModel> Put(UsuarioDTO usuario)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                UsuarioRepository _UsuarioRepository = new UsuarioRepository();
                response.CodError = 0;
                var resultado = _UsuarioRepository.UpdateUsuario(usuario);
                response.Respuesta.Add(resultado);
            }
            catch (Exception ex)
            {
                response.CodError = 999;
                response.Mensaje = ex.Message;
            }
            return response;
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public async Task<ResponseModel> Delete(int Id)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                UsuarioRepository _UsuarioRepository = new UsuarioRepository();
                response.CodError = 0;
                var resultado = await _UsuarioRepository.DeleteUsuario(Id);
                response.Respuesta.Add(resultado);
                return response;
            }
            catch (Exception ex)
            {
                response.CodError = 999;
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}