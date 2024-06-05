using FlightRestApi.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FlightRestApi.Helpers
{
    public static class SoapHelper
    {
        public static string ConvertXMLToJSON(string soapResponse)
        {
            try
            {
                Envelope envelope;
                using (StringReader reader = new StringReader(soapResponse))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
                    envelope = (Envelope)serializer.Deserialize(reader);
                }
                string jsonString = JsonConvert.SerializeObject(envelope, Newtonsoft.Json.Formatting.Indented);

                return jsonString;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error converting XML response to JSON", ex);
            }
        }
    }
}
