using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garbange.Domain.Entities;
using Garbange.Infraestructure.Data;

namespace Garbange.Infraestructure.Repositories
{
    public class RegistroSQLrepositorie
    {
        private readonly Garbange4BContext _garbange;
        public RegistroSQLrepositorie()
        {
            _garbange = new Garbange4BContext();
        }

        public IEnumerable<Registro> AllDataRegistro()
        {
            var registro = _garbange.Registros.Select(rgt => rgt);
            return registro;
        }

        public IEnumerable<Registro> GetByName(string name)
        {
            var registro = _garbange.Registros.Where(rgt => rgt.NombreUsuario == name);
            return registro;
        }
    }
}