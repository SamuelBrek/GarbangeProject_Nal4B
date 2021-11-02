using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garbange.Domain.Entities;
using Garbange.Domain.Dtos;
using Garbange.Infraestructure.Repositories;

namespace Garbange.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult AllDataRegistro()
        {
            var repository = new RegistroSQLrepositorie();
            var registro = repository.AllDataRegistro();
            var RespuestaRegistro = registro.Select(g => CreateDtoFromObject(g));
            return Ok(RespuestaRegistro);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            var repository = new RegistroSQLrepositorie();
            var registro = repository.GetByName(name);
            return Ok(registro);
        }

        private RegistroRespond CreateDtoFromObject(Registro registros)
        {
            var Dtos = new RegistroRespond(

                nombreUsuario : registros.NombreUsuario,
                nicknameUsuario : registros.NicknameUsuario,
                telefonoUsuario : registros.TelefonoUsuario,
                fechanacUsuario : registros.FechanacUsuario,
                correoUsuario : registros.CorreoUsuario
            );
            return Dtos;
        }
        #region"Request"
        private Registro CreateObjectFromDto(RegistroRequest Dto)
        {
            var registro = new Registro {
                IdRegistro = 0,
                NombreUsuario = string.Empty,
                ApellidoUsuario = string.Empty,
                NicknameUsuario = string.Empty,
                ContrasenaUsuario = string.Empty,
                NivelUsuario = string.Empty,
                TelefonoUsuario = string.Empty,
                FechanacUsuario = Dto.fechanacUsuario.Date,
                CorreoUsuario = string.Empty

            };
            return registro;
        }
        #endregion
    }
}