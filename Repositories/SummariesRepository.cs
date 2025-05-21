using Betclic.Dotnet.Interview.Models;

namespace Betclic.Dotnet.Interview.Repositories;

internal sealed class SummariesRepository : ISummariesRepository
{
    private readonly ILogger<SummariesRepository> _logger;
    private readonly string[] _summaries =
    [
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    ];

    public SummariesRepository(ILogger<SummariesRepository> logger)
    {
        _logger = logger;
    }

    public async Task<IEnumerable<Summary>> GetAsync()
    {
        var mappedSummaries = new List<Summary>();

        foreach (var summary in _summaries)
        {
            await Task.Delay(500); // Simulate async work
            mappedSummaries.Add(
                new Summary { Name = summary, Description = $"Description for {summary}" }
            );
        }

        _logger.LogInformation("Summaries retrieved successfully.");

        return mappedSummaries;
    }
}
