using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Rol
    {
        public Rol()
        {
            FuncionesXrol = new HashSet<FuncionesXrol>();
            Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ICollection<FuncionesXrol> FuncionesXrol { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
