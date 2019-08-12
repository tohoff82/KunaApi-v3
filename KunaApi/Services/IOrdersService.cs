using System.Threading.Tasks;
using System.Collections.Generic;
using KunaApi.DTO.Answers;

namespace KunaApi.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetActiveOrdersAsync(string marketMarker);
    }
}
