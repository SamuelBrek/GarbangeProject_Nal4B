using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garbange.Infraestructure.Data;
using Garbange.Domain.Entities;

namespace Garbange.Infraestructure.Repositories
{
    public class DenunciaSQLrepositorie
    {
        private readonly Garbange4BContext _garbange;
        public DenunciaSQLrepositorie()
        {
            _garbange = new Garbange4BContext();
        }

        public IEnumerable<Denuncium> AllDataDenuncia()
        {
            var denuncia = _garbange.Denuncia.Select(dnc => dnc);
            return denuncia;
        }
        public IEnumerable<Denuncium> GetByColonia(string colonia)
        {
            var denuncia = _garbange.Denuncia.Where(dnc => dnc.ColoniaDenuncia == colonia);
            return denuncia;
        }
    }
}