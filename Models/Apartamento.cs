using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeGestionDeCondominio.Models
{
	public class Apartamento
	{
		[Key]
		public string? id { get; set; }
		public string? Descripcion { get; set; }
		public int CantidadHabitacion { get; set; }
		public int Estado { get; set; }
	}
}
