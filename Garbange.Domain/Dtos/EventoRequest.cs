using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbange.Domain.Dtos
{
    public record EventoRequest(int idEvento, string nombreEvento, DateTime fechaEvento, 
    string horaEvento, int personasEvento, string ubicacionEvento, 
    string descripcionEvento, string imagenEvento);
}