namespace WebApplication2.Domain.Common
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            Respuesta = new List<object>();
        }
        public int CodError { get; set; }
        public String Mensaje { get; set; }

        public List<object> Respuesta { get; set; }
    }
}
