namespace RetailerAPI.Business
{
    public class RewardsManager 
    {

        /// <summary>
        /// Given method returns the Rewards points as per purchase amount
        /// </summary>
        /// <param name="purchaseAmount"></param>
        /// <returns>rewards point</returns>
        public static int GetRewardsPointsByAmount (int purchaseAmount)
        {
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
