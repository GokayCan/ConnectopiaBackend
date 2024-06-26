﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Connectopia.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet("deneme")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public IActionResult Get()
        {
            return Ok("Test");
        }
    }
}
