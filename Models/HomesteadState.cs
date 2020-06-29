using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;

public class HomesteadState 
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName = "fields")]
    public List<HomesteadStateField> Fields { get; set; }

    public HomesteadState()
    {
        Fields = new List<HomesteadStateField>();
    }
}

public class HomesteadStateField
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }
    [JsonProperty(PropertyName = "score")]
    public int Score { get; set; }
    [JsonProperty(PropertyName = "weight")]
    public int Weight { get; set; }
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }
}