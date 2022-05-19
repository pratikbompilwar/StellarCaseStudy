using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailerAPI.Business;
using RetailerAPI.Common.Exception;

namespace RetailerAPI.Controllers
{
    [Route("api/[controller]")]
    public class RewardsController : Controller
    {
        private readonly ILogger logger;
        public RewardsController(ILogger<RewardsController> _logger)
        {
            logger = _logger;
        }

        // GET: api/Rewards/GetRewardPoints/50
        [Route("GetRewardsPointByAmount/{purchaseAmount}")]
        [HttpGet]
        public ActionResult Get(int purchaseAmount)
        {
            try
            {
                logger.LogInformation("GetRewardsPointByAmount Method called from RewardsController with purcahse amount : " + purchaseAmount);
                int result = RewardsManager.GetRewardsPointsByAmount(purchaseAmount);

                logger.LogInformation("Returning rewards points : " + result + " for the purchase amount : " + purchaseAmount);
                return Ok(result);
            }
            catch (RewardsAppException ex)
            {
                logger.LogInformation("Error message from Rewards Controller : " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        
    }
}
