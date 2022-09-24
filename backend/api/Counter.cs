using Newtonsoft.Json;

namespace Company.Function
{
    public class counter
    {
        [JsonProperty(PropertyName="id")]
        public string ID {get; set;}
        
        [JsonProperty(PropertyName = "count")]
        public int Count {get;set;}
    }
}