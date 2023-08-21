namespace VideoRental
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            RentedMovie = movie;
            DaysRented = daysRented;
        }

        private Movie RentedMovie;
        private int DaysRented;

        public Movie GetMovie()
        {
            return RentedMovie;
        }
        public void SetMovie(Movie movie)
        {
            RentedMovie = movie;
        }

        public int GetDaysRented()
        {
            return DaysRented;
        }
        public void SetDaysRented(int daysRented)
        {
            DaysRented = daysRented;
        }
        public double GetRentalPrice()
        {
            return RentedMovie.GetRentalPrice().CalculatePrice(DaysRented);
        }
    }
}
