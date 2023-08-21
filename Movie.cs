namespace VideoRental
{

    public class Movie
    {
        public enum EnumPriceCode
        {
            REGULAR = 0,
            NEW_RELEASE = 1,
            CHILDRENS = 2,
            EXAMPLE_GENRE = 3
        }
        public Movie(string title, EnumPriceCode priceCode = EnumPriceCode.REGULAR)
        {
            Title = title;
            PriceCode = priceCode;
        }

        private string Title=null;
        private EnumPriceCode PriceCode = EnumPriceCode.REGULAR;
        private double RentalPrice =0;

        public string GetTitle()
        {
            return Title;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }

        public EnumPriceCode GetPriceCode() 
        { 
            return PriceCode; 
        }
        public void SetPriceCode(EnumPriceCode priceCode)
        {
            PriceCode = priceCode;
        }

        public double GetRentalPrice()
        { 
            return RentalPrice; 
        }
        public void SetRentalPrice(double rentalPrice)
        {
            RentalPrice = rentalPrice;
        }
     

    }
}
