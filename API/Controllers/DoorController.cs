﻿using API.Models;
using API.Services.IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [EnableCors("CORSPolicy")]
    [Route("[controller]")]
    public class DoorController : ControllerBase
    {   
            private readonly IDoorService _doorService;

            public DoorController(IDoorService doorService)
            {
            _doorService = doorService;
            }     

            [HttpGet("FindEntriesByDoor")]
            public async Task<List<Output>> FindEntriesByDoor(string name)
            {
                return await _doorService.FindEntriesByDoor(name);
            }

        [HttpGet("FindEntriesByCode")]
        public async Task<List<Output>> FindEntriesByCode(string name)
        {
            return await _doorService.FindEntriesByCode(name);
        }

        [HttpGet("FindEntriesByTag")]
        public async Task<List<Output>> FindEntriesByTag(string name)
        {
            return await _doorService.FindEntriesByTag(name);
        }

        [HttpGet("FindEntriesByDörrBenämning")]
        public async Task<List<Output>> FindEntriesByDörrBenämning(string name)
        {
            return await _doorService.FindEntriesByDörrBenämning(name);
        }

<<<<<<< HEAD
        [HttpGet("FindEntriesByTenant")]
        public async Task<List<Output>> FindEntriesByTenant(string name)
        {
            return await _doorService.FindEntriesByTenant(name);
=======
        [HttpGet("ListTentatsAt")]
        public async Task<List<Tenant>> ListTentatsAt(string name)
        {
            return await _doorService.ListTenantsAt(name);
>>>>>>> main
        }
    }
 }
