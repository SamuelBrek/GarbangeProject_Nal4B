using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbange.Domain.Dtos
{
    public record RegistroRequest(int idRegistro, string nombreUsuario, string apellidoUsuario, 
    string nicknameUsuario, string contrasenaUsuario, string nivelUsuario, string telefonoUsuario, 
    DateTime fechanacUsuario, string correoUsuario);
}