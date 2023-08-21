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
            movieTitle = title;
            moviePriceCode = priceCode;
        }

        public int getPriceCode() { return moviePriceCode; }
        public double getPrice() { return moviePrice; }

        public void setPriceCode(int args) { moviePriceCode = args; }

        public void setPrice(double args) { moviePrice = args; }


        public string getTitle() { return movieTitle; }

        private string movieTitle;
        int moviePriceCode;
        double moviePrice; 
    }
}
