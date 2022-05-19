using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailerAPI.Business;

namespace RetailerAPI.Controllers
{
    [Route("api/[controller]")]
    public class RewardsController : Controller
    {
        
        // GET: api/Rewards/GetRewardPoints/50
        [Route("GetRewardsPointByAmount/{purchaseAmount}")]
        [HttpGet]
        public ActionResult Details(int purchaseAmount)
        {
            int result = RewardsManager.GetRewardsPointsByAmount(purchaseAmount);

            return Ok(result);
        }

        
    }
}
