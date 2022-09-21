using DailyMutualFundNAV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Repository
{
    public class MutualFundRepository:IMutualFundRepository
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MutualFundRepository));
        private readonly MutualFundContext db;
        public MutualFundRepository(MutualFundContext _db)
        {
            db = _db;
        }
        public DailyMutualFundDetail GetMutualFundByNameRepository(string mutualFundName)
        {
            DailyMutualFundDetail mutualFundData = null;

            mutualFundData = db.DailyMutualFundDetails.Where(x => x.MutualFundName == mutualFundName).FirstOrDefault();
            return mutualFundData;
        }
        public List<DailyMutualFundDetail> GetAllmutualFund()
        {
            return db.DailyMutualFundDetails.ToList();
        }
    }
}
