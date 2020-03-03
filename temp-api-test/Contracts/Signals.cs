using System;
using Newtonsoft.Json;
namespace tempapitest.Contracts
{
    [JsonObject, Serializable]
    public class Signals
    {
    public int id { get; set; }
    public string Signal { get; set; }
    }
}
