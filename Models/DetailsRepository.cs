namespace AspWebApplicationDemo.Models
{
    public class DetailsRepository:IDetailsRepository
    {
        private Details information;

        public DetailsRepository()
        {

            information = new Details()
            {

                number = 1,
                name = "pavan",

            };
        }

        public Details GetDetails()
        {
            return information;
        }
    }
}
