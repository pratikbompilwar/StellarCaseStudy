using RetailerAPI.Common.Exception;

namespace RetailerAPI.Business
{
    public class RewardsManager : IRewardsManager
    {
       
        /// <summary>
        /// Given method returns the Rewards points as per purchase amount
        /// </summary>
        /// <param name="purchaseAmount"></param>
        /// <returns>rewards point</returns>
        public  int GetRewardsPointsByAmount (int purchaseAmount)
        {
            if(purchaseAmount < 0)
            {
                throw new RewardsAppException("Error :Invalid purchase amount value.Purchase amount cannot be less than zero.");
            }
            // applying first condition for calculating rewardsPoint
            int rewardsPoint = purchaseAmount > 50 ? (purchaseAmount - 50) : 0;

            // applying second condition for calculating rewardsPoint
            if (purchaseAmount > 100)
            {
                rewardsPoint += purchaseAmount - 100;
            }

            return rewardsPoint;
        }
    }
}
