using System.Text.Json.Serialization;

namespace Betclic.Dotnet.Interview.Models;

public class Summary
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}
