using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class FuncionesXrol
    {
        public int Id { get; set; }
        public int? RolId { get; set; }
        public int? FuncionId { get; set; }

        public Funcion Funcion { get; set; }
        public Rol Rol { get; set; }
    }
}
