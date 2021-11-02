using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbange.Domain.Dtos
{
    public record DenunciaRequest (int idDenuncia, string motivoDenuncia, DateTime fechaDenuncia, 
    string descripcionDenuncia, string ubicacionDenuncia, string coloniaDenuncia, string imagenDenuncia);
}