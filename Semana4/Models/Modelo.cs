using System.ComponentModel.DataAnnotations;

namespace Semana4.Models
{
        public class Modelo
        {
            public int Id { get; set; }
            public string Titulo { get; set; }

            [DataType(DataType.Date)]
            public DateTime FechaRealizacion { get; set; }
            public string Genero { get; set; }
            public decimal Precio { get; set; }
        }
    }
