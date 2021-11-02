using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garbange.Infraestructure.Repositories;
using Garbange.Domain.Entities;
using Garbange.Domain.Dtos;

namespace Garbange.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult AllDataEvento()
        {
            var repository = new EventoSQLrepositorie();
            var eventos = repository.AllDataEvento();
            var RespuestaEvento = eventos.Select(g => CreateDtoFromObject(g));
            return Ok(RespuestaEvento);
        }

        [HttpGet]
        [Route("GetByEvento/{nameEvento}")]
        public IActionResult GetByEvento(string nameEvento)
        {
            var repository = new EventoSQLrepositorie();
            var eventos = repository.GetByEvento(nameEvento);
            return Ok(eventos);
        }

        private EventoRespond CreateDtoFromObject(Evento eventos)
        {
            var Dtos = new EventoRespond(

                idEvento : eventos.IdEvento,
                nombreEvento : eventos.NombreEvento,
                personasEvento : eventos.PersonasEvento,
                ubicacionEvento : eventos.UbicacionEvento,
                descripcionEvento : eventos.DescripcionEvento
            );
            return Dtos;
        }
        #region"Request"
        private Evento CreateObjectFromDto(EventoRequest Dto)
        {
            var evento = new Evento {
                IdEvento = 0,
                NombreEvento = string.Empty,
                FechaEvento = Dto.fechaEvento.Date,
                HoraEvento = string.Empty,
                PersonasEvento = 0,
                UbicacionEvento = string.Empty,
                DescripcionEvento = string.Empty,
                ImagenEvento = string.Empty

            };
            return evento;
        }
        #endregion
    }
}