using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Signature.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignatureController : ControllerBase
    {
     
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };*/

        private readonly ILogger<SignatureController> _logger;

        public SignatureController(ILogger<SignatureController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<SignatureInformation> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new SignatureInformation
            {
                DocumentID = index.ToString(),
                DocumentTitle = "TEST",
                SignatureDate= DateTime.Now.AddDays(index),
                AuthenticatedAccount="100" + index.ToString()
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]


            })
            .ToArray();
        }
    }
}
