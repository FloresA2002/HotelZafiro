namespace HotelZafiro.Models
{
    public class TipoPersonaModel : HotelModel
    {
        public string Descripcion { get; set; }
        public string FechaCreacion { get; set; }
        public string PersonaId { get; set; }
        public PersonaModel Persona { get; set; }
        
        
    }
}
