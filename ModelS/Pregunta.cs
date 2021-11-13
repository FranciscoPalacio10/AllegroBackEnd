using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Pregunta
    {
        public int Id { get; set; }
        public string Pregunta1 { get; set; }
        public byte[] Imagen { get; set; }
        public int? RecompensaId { get; set; }
        public int? UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
