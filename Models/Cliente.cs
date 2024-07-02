using System;
namespace SistemaDeGestionDeCondominio.Models
{
	public class Cliente
	{
        public int id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public int IdParqueo { get; set; }
        public int Estado { get; set; }

    }
}

