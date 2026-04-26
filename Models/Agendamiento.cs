using System;

namespace RIVEROSCRUZ_PATITASFELICES.Models
{
    public class Agendamiento
    {
        public int IdAgendamiento { get; set; }
        public string NombreDueno { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreMascota { get; set; }
        public string TipoMascota { get; set; }
        public int EdadMascota { get; set; }
        public DateTime FechaAtencion { get; set; }
        public TimeSpan HoraAtencion { get; set; }
        public string MotivoConsulta { get; set; }
        public string Estado { get; set; }
    }
}
