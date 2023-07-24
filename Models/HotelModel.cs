using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelZafiro.Models
{
    public abstract class HotelModel
    {
        public string Id { get; set; }

        public HotelModel()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
