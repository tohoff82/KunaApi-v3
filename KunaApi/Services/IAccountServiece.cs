using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;

namespace KunaApi.Services
{
    public interface IAccountServiece
    {
        Task<Account> GetAccountAsync();
        Task<IEnumerable<Balance>> GetBalanceAsync();
    }
}
