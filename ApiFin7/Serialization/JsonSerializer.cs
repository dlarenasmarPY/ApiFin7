using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Web.Api.Serialization
{
    public class JsonSerializer
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            ContractResolver = (IContractResolver)new JsonSerializer.JsonContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string SerializeObject(object o) => JsonConvert.SerializeObject(o, Formatting.Indented, JsonSerializer.Settings);

        public sealed class JsonContractResolver : CamelCasePropertyNamesContractResolver
        {
        }
    }
}
