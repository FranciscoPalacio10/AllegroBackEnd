using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class PlanEstudioDetalle
    {
        public PlanEstudioDetalle()
        {
            ClaseCabecera = new HashSet<ClaseCabecera>();
        }

        public int Id { get; set; }
        public int? PlanEstudioCabeceraId { get; set; }
        public int? EstiloId { get; set; }
        public int? CursoId { get; set; }
        public int? Horas { get; set; }

        public Curso Curso { get; set; }
        public Estilo Estilo { get; set; }
        public PlanEstudioCabecera PlanEstudioCabecera { get; set; }
        public ICollection<ClaseCabecera> ClaseCabecera { get; set; }
    }
}
