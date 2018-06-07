using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify.Negocio.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public String Nome_usuario { get; set; }
        public String Email_usuario { get; set; }
        public String Login_usuario { get; set; }
        public String Password_usuario { get; set; }
        public bool Administrador_usuario { get; set; }
    }
}
