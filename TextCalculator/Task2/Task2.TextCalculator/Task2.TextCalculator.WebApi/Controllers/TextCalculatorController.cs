using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextCalculator.BusinessLayer.Interfaces;

namespace Task2.TextCalculator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextCalculatorController : ControllerBase
    {
        private readonly ITextCalculator _textCalculator;
        public TextCalculatorController(ITextCalculator textCalculator)
        {
            _textCalculator = textCalculator;
        }

        [HttpGet("add/{str}")]
        public ActionResult<string> Add(string str)
        {
            try
            {
                var result = _textCalculator.Add(str);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
