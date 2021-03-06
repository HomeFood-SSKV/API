﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using DotnetCore.Business.Interfaces;
using DotnetCore.Business.Entities;
using DotnetCore.Web.Controllers;
using WebApi.Common.JwtParser;
using Microsoft.Extensions.Configuration;
using WebApi.Common;
using WebApi.Common.Helper;

namespace Chinook.API.Controllers
{
    [Route("api/[controller]")]
    public class IdentityController : BaseController
    {
        private readonly JwtService _jwtService;
 
        public IdentityController(JwtService jwtService)
        {
            this._jwtService = jwtService;
        }
       
        [HttpGet]
        [Route("authorise")]
        [Produces(typeof(List<JwtClaim>))]
        public async Task<IActionResult> Authorise(string userName, string password,CancellationToken ct = default(CancellationToken))
        {
            try
            {
                return Ok(await _jwtService.Authenticate(userName, password));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(MAS_AddressTypeDto))]
        public async Task<IActionResult> Get(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                return Ok(await businessSupervisor.GetMASAddressTypeById(id, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Produces(typeof(MAS_AddressTypeDto))]
        public async Task<IActionResult> Register([FromBody]MAS_AddressTypeDto input, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                if (input == null)
                    return BadRequest();
                return StatusCode(201, await businessSupervisor.InsertMASAddressType(input, true, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
 
    }
}
