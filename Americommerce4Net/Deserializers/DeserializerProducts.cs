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
    public class DeserializerProducts : BaseDeserializer
    {
        protected override string ModifyJsonContent(string content) {
            string json = content.Replace("\"products\":[", "\"items\":[");
            return json;
        }
    }
}
