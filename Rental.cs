
namespace VideoRental
{
    using System;

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
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rental.GetMovie() :An error occurred: {ex.Message}");
            }
            return RentedMovie;
        }
        public void SetMovie(Movie movie)
        {
            try
            {
                RentedMovie = movie;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rental.SetMovie() :An error occurred: {ex.Message}");
            }
        }

        public int GetDaysRented()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rental.GetDaysRented() :An error occurred: {ex.Message}");
            }
            return DaysRented;
        }
        public void SetDaysRented(int daysRented)
        {
            try
            {
                DaysRented = daysRented;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rental.SetDaysRented() :An error occurred: {ex.Message}");
            }
        }
        public double GetRentalPrice()
        {
            double price = 0.0;
            try
            {
                price = RentedMovie.GetRentalPrice().CalculatePrice(DaysRented);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rental.GetRentalPrice() :An error occurred: {ex.Message}");
            }
            return price;
        }
    }
}
