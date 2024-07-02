using System.ComponentModel.DataAnnotations;

namespace SistemaDeGestionDeCondominio.Models
{
	public class Parqueo
	{
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
    }
}

