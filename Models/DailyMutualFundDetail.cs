using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Models
{
    public class DailyMutualFundDetail
    {

        [Key]
        public int MutualFundId { get; set; }
        public string MutualFundName { get; set; }
        public double MutualFundvalue { get; set; }
    }
}
