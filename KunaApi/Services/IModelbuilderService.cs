using KunaApi.DTO.Answers;
using System.Collections.Generic;

namespace KunaApi.Services
{
    public interface IModelbuilderService
    {
        IReadOnlyCollection<Ticker> CreateTickerList(List<List<string>> crudeTickers);
    }
}
