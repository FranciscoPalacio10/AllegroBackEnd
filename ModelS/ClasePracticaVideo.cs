using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class ClasePracticaVideo
    {
        public int Id { get; set; }
        public string LinkVideo { get; set; }
        public string LinkStorage { get; set; }
        public int? ClaseDetalleId { get; set; }

        public ClaseDetalle ClaseDetalle { get; set; }
    }
}
