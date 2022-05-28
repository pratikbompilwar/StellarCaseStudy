namespace RetailerAPI.Business
{
    public interface IRewardsManager
    {
         int GetRewardsPointsByAmount(int purchaseAmount);
    }
}
