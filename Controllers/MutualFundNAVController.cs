using DailyMutualFundNAV.Models;
using DailyMutualFundNAV.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MutualFundNAVController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MutualFundNAVController));
        private readonly IMutualFundRepository mutualFundRepository;
       
        public MutualFundNAVController(IMutualFundRepository _mutualFundRepository)
        {
            _log4net.Info("MutualFundNAVController Initiated");
            mutualFundRepository = _mutualFundRepository;
        }
        [HttpGet]
        [Route("mutualfundname")]
        public IActionResult GetMutualFundByName(string mutualfundname)
        {
            try
            {
                if (mutualfundname == null)
                {
                    _log4net.Info("MutualFund Null Name.");
                    return BadRequest("Name Cannot be null");
                }
                _log4net.Info("In MutualFundNAV Controller, " + mutualfundname + " is searched");
                var mutualFundData = mutualFundRepository.GetMutualFundByNameRepository(mutualfundname);
                if (mutualFundData == null)
                {
                    _log4net.Info(mutualfundname + " is invalid MutualFund.");
                    return NotFound("Invalid MutualFund Name");
                    //return BadRequest();
                }
                else
                {
                    _log4net.Info(mutualfundname + " MutualFund Found.");
                    return Ok(mutualFundData);
                }
                //return Ok(mutualFundData);
            }
            catch (Exception exception)
            {
                _log4net.Error("Exception Found=" + exception.Message);
                return new StatusCodeResult(500);
            }

        }
        [HttpGet]
        public ActionResult GetAllMutualFund()
        {
            var l = mutualFundRepository.GetAllmutualFund();
            return Ok(l);
        }
    }
}
