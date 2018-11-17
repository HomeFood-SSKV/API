using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using DotnetCore.Business.Interfaces;
using DotnetCore.Business.Entities;
using DotnetCore.Web.Controllers;

namespace Chinook.API.Controllers
{
    [Route("api/[controller]")]
    public class CityController : BaseController
    {


        [HttpGet]
        [Produces(typeof(List<MAS_CityDto>))]
        public async Task<IActionResult> Get(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                return Ok(await businessSupervisor.GetMASCity( ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(MAS_CityDto))]
        public async Task<IActionResult> Get(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                return Ok(await businessSupervisor.GetCityById(id, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Produces(typeof(MAS_CityDto))]
        public async Task<IActionResult> Post([FromBody]MAS_CityDto input, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                if (input == null)
                    return BadRequest();
                return StatusCode(201, await businessSupervisor.InsertMASCity(input,true, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        [Produces(typeof(MAS_CityDto))]
        public async Task<IActionResult> Put(int id, [FromBody]MAS_CityDto input, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await businessSupervisor.GetCityById(id, ct) == null)
                {
                    return NotFound();
                }

                if (await businessSupervisor.UpdateMASCity(input,true, ct))
                {
                    return Ok(input);
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        [Produces(typeof(void))]
        public async Task<ActionResult> Delete(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                if (await businessSupervisor.GetCityById(id, ct) == null)
                {
                    return NotFound();
                }

                if (await businessSupervisor.DeleteMASArea(id,true, ct))
                {
                    return Ok();
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
