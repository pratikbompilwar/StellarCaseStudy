namespace RetailerAPI.Common.Exception
{
    public class RewardsAppException : System.Exception
    {
        public RewardsAppException()
            : base()
        {

        }

        public RewardsAppException(string errorMessage)
            : base(errorMessage)
        {

        }

        public RewardsAppException(string errorMessage, System.Exception innerException)
            : base(errorMessage, innerException)
        {

        }



    }
}
