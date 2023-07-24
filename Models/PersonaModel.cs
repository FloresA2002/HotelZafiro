namespace HotelZafiro.Models
{
    public class PersonaModel : HotelModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string FechaCreacion { get; set; }
        public List<TipoPersonaModel> TipoPersonas { get; set; }
    }

    
}
