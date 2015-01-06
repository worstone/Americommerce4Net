using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Deserializers
{
    public class DeserializerFields : IDeserializer
    {
        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public T Deserialize<T>(IRestResponse response) {
            if (string.IsNullOrEmpty(response.Content)) {
                return default(T);
            }
            if (response.StatusCode == System.Net.HttpStatusCode.OK ||
                response.StatusCode == System.Net.HttpStatusCode.Created ||
                response.StatusCode == System.Net.HttpStatusCode.Accepted ||
                response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                try {
                    var json = response.Content.Replace("\"products\": [", "\"items\": [");
                    return JsonConvert.DeserializeObject<T>(json);

                } catch (JsonSerializationException ex) {
                    LoggingService.Log(this).ErrorFormat("NewtonSoftJsonDeserializer | {0}", response.ResponseUri, ex);
                    throw new DeserializerException(ex.Message) { RestResponse = response };
                }
            }
            return default(T);
        }
    }

}
