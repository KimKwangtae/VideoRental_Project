namespace VideoRental
{

    public class Movie
    {
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDRENS = 2;
        public const int EXAMPLE_GENRE = 3; //새로운 장르 추가

        public Movie(string title, int priceCode = REGULAR)
        {
            Title = title;
            PriceCode = priceCode;
        }

        private string Title=null;
        private int PriceCode =0;
        private double RentalPrice =0;

        public string GetTitle()
        {
            return Title;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }

        public int GetPriceCode() 
        { 
            return PriceCode; 
        }
        public void SetPriceCode(int priceCode)
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
