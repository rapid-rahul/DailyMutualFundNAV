using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Models
{
    public class MutualFundContext:DbContext
    {
        
        public MutualFundContext() { }
            public MutualFundContext(DbContextOptions options) : base(options) { }

            public DbSet<DailyMutualFundDetail> DailyMutualFundDetails { get; set; }
    }
    
}
