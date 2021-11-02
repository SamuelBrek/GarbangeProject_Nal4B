using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbange.Domain.Dtos
{
    public record RegistroRespond(string nombreUsuario, string nicknameUsuario, string telefonoUsuario, 
    DateTime fechanacUsuario, string correoUsuario);
}