using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailerAPI.Business;

namespace RetailerAPI.tests.FakeServices
{
    public class RewardsManagerFake : IRewardsManager
    {
        public int GetRewardsPointsByAmount(int purchaseAmount)
        {
            return 90;
        }
    }
}
