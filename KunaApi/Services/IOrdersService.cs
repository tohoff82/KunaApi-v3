using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using KunaApi.DTO.Answers;

namespace KunaApi.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetActiveOrdersAsync(string marketMarker);
        Task<IEnumerable<Order>> GetAllExecutedOrdersAsync(DateTime start, 
                            DateTime end, ushort limit, sbyte sort);
        Task<IEnumerable<Order>> GetExecutedOrdersAsync(string marketMarker,
            DateTime start, DateTime end, ushort limit, sbyte sort);
    }
}
