using RestSharp;
using System;
using System.Configuration;
using System.Linq;
using System.Globalization;
using Americommerce4Net.Logging;

namespace Americommerce4Net.Clients
{
    public class ClientServerTools
    {
        string _ServiceUrl;

        public ClientServerTools() {
            _ServiceUrl = ConfigurationManager.AppSettings["Americommerce4Net_ServiceURL"];
        }

        public ClientServerTools(Configuration configuration) {
            _ServiceUrl = configuration.ServiceURL;
        }
        
        public DateTime? GetServerDateTime() {
            
            var client = new RestClient(_ServiceUrl);
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            var date_header = response.Headers.Where(x => x.Name == "Date").FirstOrDefault();
            if (date_header != null && date_header.Value != null) {

                DateTime server_date_time;

                try {
                    server_date_time = DateTime.ParseExact(date_header.Value.ToString(),
                        "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                        CultureInfo.InvariantCulture.DateTimeFormat,
                        DateTimeStyles.AssumeUniversal);
                } catch (Exception ex) {
                    LoggingService.Log(this).Error("Error Parsing Server Date Time.", ex);
                    return null;
                }
                return server_date_time;
            }
            return null;
        }
    }
}
