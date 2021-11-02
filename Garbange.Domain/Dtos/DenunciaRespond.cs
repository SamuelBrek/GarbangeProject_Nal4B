using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbange.Domain.Dtos
{
    public record DenunciaRespond (int idDenuncia, string motivoDenuncia, 
    string descripcionDenuncia, string coloniaDenuncia);
}