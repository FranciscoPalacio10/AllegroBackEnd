using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Funcion
    {
        public Funcion()
        {
            FuncionesXrol = new HashSet<FuncionesXrol>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ICollection<FuncionesXrol> FuncionesXrol { get; set; }
    }
}
