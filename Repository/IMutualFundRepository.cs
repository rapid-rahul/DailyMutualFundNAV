using DailyMutualFundNAV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Repository
{
    public interface IMutualFundRepository
    {
        DailyMutualFundDetail GetMutualFundByNameRepository(string mutualFundName);
        List<DailyMutualFundDetail> GetAllmutualFund();
    }
}
