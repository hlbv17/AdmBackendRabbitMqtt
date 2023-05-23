﻿using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/camion")]
    [ApiController]
    public class CamionController : ControllerBase
    {
        private readonly ICamionServices _services;

        public CamionController(ICamionServices services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CamionModel camion)
        {
            camion.TipoPeticion = "POST";
            _services.Transfer(camion);
            return Ok(camion);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] CamionModel camion)
        {
            camion.TipoPeticion = "PUT";
            _services.Editar(camion);
            return Ok(camion);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] CamionModel camion)
        {
            camion.TipoPeticion = "DELETE";
            _services.Eliminar(camion);
            return Ok(camion);
        }
    }
}
