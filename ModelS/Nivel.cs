using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Nivel
    {
        public Nivel()
        {
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? NumeroEstrellas { get; set; }
        public bool? IsActive { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
}
