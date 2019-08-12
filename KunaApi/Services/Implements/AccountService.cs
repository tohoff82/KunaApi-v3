using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;
using KunaApi.POCO.Requests;
using KunaApi.POCO;

namespace KunaApi.Services.Implements
{
    public class AccountService : KunaHttp, IAccountServiece
    {
        private readonly IAuthconfigService _authconfig;
        private readonly IModelbuilderService _modelbuilder;

        public AccountService(IAuthconfigService authconfig, IModelbuilderService modelbuilder) : base()
        {
            _authconfig = authconfig;
            _modelbuilder = modelbuilder;
        }

        public async Task<Account> GetAccountAsync()
            => await HttpPostAsync<Account>(new AccountRequest(), _authconfig.PublicKey, _authconfig.SecretKey);

        public async Task<IEnumerable<Balance>> GetBalanceAsync()
        {
            string[][] crudeBalances = await HttpPostAsync<string[][]>(new BalanceRequest(), _authconfig.PublicKey, _authconfig.SecretKey);
            return _modelbuilder.CreateBalances(crudeBalances);
        }
    }
}
