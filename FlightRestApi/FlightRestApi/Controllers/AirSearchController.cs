using FlightRestApi.Helpers;
using FlightRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FlightRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirSearchController : ControllerBase
    {
        [HttpPost("availability")]
        public async Task<IActionResult> AvailabilitySearch([FromBody] SearchRequest request)
        {
            try
            {
                var response = await SendSoapRequest(request);
                var result = SoapHelper.ConvertXMLToJSON(response);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message, detail = ex.InnerException?.Message });
            }
        }

        [HttpGet("airports")]
        public IActionResult GetAirports()
        {
            try
            {
                var airports = AirportHelper.GetAirports();
                return Ok(airports);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message, detail = ex.InnerException?.Message });
            }
        }


        private async Task<string> SendSoapRequest(SearchRequest request)
        {
            try
            {
                var soapEnvelope = $@"
        <soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:tem='http://tempuri.org/'>
            <soapenv:Header/>
            <soapenv:Body>
                <tem:AvailabilitySearch>
                    <tem:request>
                        <tem:Origin>{request.Origin}</tem:Origin>
                        <tem:Destination>{request.Destination}</tem:Destination>
                        <tem:DepartureDate>{request.DepartureDate:yyyy-MM-ddTHH:mm:ss}</tem:DepartureDate>";

                if (request.ReturnDate != DateTime.MinValue)
                {
                    soapEnvelope += $@"
                        <tem:ReturnDate>{request.ReturnDate:yyyy-MM-ddTHH:mm:ss}</tem:ReturnDate>";
                }

                soapEnvelope += @"
                    </tem:request>
                </tem:AvailabilitySearch>
            </soapenv:Body>
        </soapenv:Envelope>";

                using (var client = new HttpClient())
                {
                    var content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");
                    content.Headers.Add("SOAPAction", "\"http://tempuri.org/IAirSearch/AvailabilitySearch\"");

                    var response = await client.PostAsync("https://localhost:5001/Service.svc", content);
                    response.EnsureSuccessStatusCode();
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
            }
            catch (HttpRequestException httpRequestEx)
            {
                throw new ApplicationException("Error sending SOAP request", httpRequestEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred", ex);
            }
        }
    }
}
