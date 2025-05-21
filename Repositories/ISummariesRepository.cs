using Betclic.Dotnet.Interview.Models;

namespace Betclic.Dotnet.Interview.Repositories;

public interface ISummariesRepository
{
    Task<IEnumerable<Summary>> GetAsync();
}
