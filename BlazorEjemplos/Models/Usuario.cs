using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorEjemplos.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int RolId { get; set; }
        public string Password { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
