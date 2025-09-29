namespace LandingDB.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string? Nombre_Apellido { get; set; }
        public string? Mensaje { get; set; }
        public string? Email { get; set; }
        public DateTime Fecha_Contacto { get; set; }
    }
}
