using System.Collections.Generic;
using System.Threading.Tasks;
using KunaApi.DTO.Answers;
using KunaApi.POCO.Requests;
using KunaApi.POCO;

namespace KunaApi.Services.Implements
{
    public class AccountService : KunaHttp, IAccountServiece
    {
        private readonly IOptionsService _options;
        private readonly IModelbuilderService _builder;

        public AccountService(IOptionsService options,
                              IModelbuilderService builder) : base()
        {
            _options = options;
            _builder = builder;
        }

        public async Task<Account> GetAccountAsync()
            => await HttpPostAsync<Account>(new AccountRequest(),
                _options.PublicKey, _options.SecretKey);

        public async Task<IEnumerable<Balance>> GetBalanceAsync()
        {
            string[][] crudeBalances = await HttpPostAsync<string[][]>(
                new BalanceRequest(), _options.PublicKey, _options.SecretKey);
            return _builder.CreateBalances(crudeBalances);
        }
    }
}
