using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Usuario
    {
        public Usuario()
        {
            ClaseCabecera = new HashSet<ClaseCabecera>();
            Curso = new HashSet<Curso>();
            Estilo = new HashSet<Estilo>();
            Nivel = new HashSet<Nivel>();
            PlanEstudioCabecera = new HashSet<PlanEstudioCabecera>();
            Pregunta = new HashSet<Pregunta>();
            Respuesta = new HashSet<Respuesta>();
        }

        public int Id { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? RolId { get; set; }

        public Rol Rol { get; set; }
        public ICollection<ClaseCabecera> ClaseCabecera { get; set; }
        public ICollection<Curso> Curso { get; set; }
        public ICollection<Estilo> Estilo { get; set; }
        public ICollection<Nivel> Nivel { get; set; }
        public ICollection<PlanEstudioCabecera> PlanEstudioCabecera { get; set; }
        public ICollection<Pregunta> Pregunta { get; set; }
        public ICollection<Respuesta> Respuesta { get; set; }
    }
}
