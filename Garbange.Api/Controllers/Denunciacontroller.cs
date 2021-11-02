using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garbange.Infraestructure.Repositories;
using Garbange.Domain.Entities;
using Garbange.Domain.Dtos;
using System.Security.AccessControl;
using System.Runtime.InteropServices;

namespace Garbange.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Denunciacontroller : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult AllDataDenuncia()
        {
            var repository = new DenunciaSQLrepositorie();
            var denuncias = repository.AllDataDenuncia();
            var RespuestaDenuncia = denuncias.Select(g => CreateDtoFromObject(g));
            return Ok(RespuestaDenuncia);
        }

        [HttpGet]
        [Route("GetByColonia/{colonia}")]
        public IActionResult GetByColonia(string colonia)
        {
            var repository = new DenunciaSQLrepositorie();
            var denuncias = repository.GetByColonia(colonia);
            return Ok(denuncias);
        }


        private DenunciaRespond CreateDtoFromObject(Denuncium denuncias)
        {
            var Dtos = new DenunciaRespond(

                idDenuncia : denuncias.IdDenuncia,
                motivoDenuncia : denuncias.MotivoDenuncia,
                descripcionDenuncia : denuncias.DescripcionDenuncia,
                coloniaDenuncia : denuncias.ColoniaDenuncia
            );
            return Dtos;
        }
        #region"Request"
        private Denuncium CreateObjectFromDto(DenunciaRequest Dto)
        {
            var denuncia = new Denuncium {
                IdDenuncia = 0,
                FechaDenuncia = Dto.fechaDenuncia.Date,
                MotivoDenuncia = string.Empty,
                DescripcionDenuncia = string.Empty,
                UbicacionDenuncia = string.Empty,
                ColoniaDenuncia = string.Empty,
                ImagenDenuncia = string.Empty

            };
            return denuncia;
        }
        #endregion
    }

}
