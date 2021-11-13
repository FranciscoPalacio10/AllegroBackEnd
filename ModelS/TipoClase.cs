using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class TipoClase
    {
        public TipoClase()
        {
            ClaseDetalle = new HashSet<ClaseDetalle>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ICollection<ClaseDetalle> ClaseDetalle { get; set; }
    }
}
