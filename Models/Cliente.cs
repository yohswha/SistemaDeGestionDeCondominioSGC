using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionDeCondominio.Models
{
	public class Cliente
	{
        [Key]
        public int id { get; set; }
        [required]
        public string? Nombre { get; set; }
        [required]
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [required]
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        [ForeignKey("Parqueo")]
        public int IdParqueo { get; set; }
        public ICollection<Parqueo>? parqueos { get; set; }
        public int Estado { get; set; }

    }
}

