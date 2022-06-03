using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PublicSoapAPIsServiceReference;
using System;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
        // http://localhost:2988/conversion/number-to-words?number=100
        //
        [HttpGet("/conversion/number-to-words")]
        public async Task<String> Get([FromQuery(Name = "number")] ulong number)
        {
            NumberConversionSoapTypeClient client = new NumberConversionSoapTypeClient(NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);

            NumberToWordsResponse response = await client.NumberToWordsAsync(number);

            return response.Body.NumberToWordsResult;
        }
    }
}