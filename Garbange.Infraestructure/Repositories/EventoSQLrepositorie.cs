using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garbange.Domain.Entities;
using Garbange.Infraestructure.Data;

namespace Garbange.Infraestructure.Repositories
{
    public class EventoSQLrepositorie
    {
        private readonly Garbange4BContext _garbange;
        public EventoSQLrepositorie()
        {
            _garbange = new Garbange4BContext();
        }

        public IEnumerable<Evento> AllDataEvento()
        {
            var evento = _garbange.Eventos.Select(evn => evn);
            return evento;
        }

        public IEnumerable<Evento> GetByEvento(string nameEvento)
        {
            var evento = _garbange.Eventos.Where(evn => evn.NombreEvento == nameEvento);
            return evento;
        }
    }
}