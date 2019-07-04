using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BFFExample.Routes;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace BFFExample.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private Endpoints api = new Endpoints();
        private readonly IHttpClientFactory _clientFactory;

        public ValuesController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }


        // GET api/values
        [HttpGet("/cars")]
        public async Task<ActionResult> Cars()
        {                                 
            var client = _clientFactory.CreateClient();            
            String result = await client.GetStringAsync(api.carsMS.getCars);            
            return Ok(result);           
        }

        // GET api/values
        [HttpPost("/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Login(Object obj)
        {
            var client = _clientFactory.CreateClient();            
            HttpResponseMessage result = await client.PostAsJsonAsync<Object>(api.authMS.login, obj);            
            return Ok(result.StatusCode);
        }
    }
}
