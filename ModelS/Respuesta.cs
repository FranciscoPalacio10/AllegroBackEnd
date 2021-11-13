using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Respuesta
    {
        public int Id { get; set; }
        public int? PreguntaId { get; set; }
        public string Respuesta1 { get; set; }
        public byte[] Imagen { get; set; }
        public bool IsCorrect { get; set; }
        public int? UsuarioId { get; set; }

        public Respuesta IdNavigation { get; set; }
        public Usuario Usuario { get; set; }
        public Respuesta InverseIdNavigation { get; set; }
    }
}
