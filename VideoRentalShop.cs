namespace VideoRental
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VideoRentalShop
    {
        public VideoRentalShop(string storeName)
        {
            StoreName = storeName;
        }

        private string StoreName;
        private List<Movie> Movies = new List<Movie>();
        private List<Customer> Customers = new List<Customer>();

        public void AddMovie(string title, Movie.EnumPriceCode priceCode)
        {
            try
            {
                Movies.Add(new Movie(title, priceCode));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"VideoRentalShop.AddMovie() :An error occurred: {ex.Message}");
            }
        }
        public void AddCustomer(string customerName)
        {
            try 
            { 
                Customers.Add(new Customer(customerName));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"VideoRentalShop.AddCustomer() :An error occurred: {ex.Message}");
            }
        }
        public void AddRental(string customerName,string movieTitle,int daysRented)
        {
            try
            { 
                var customer=Customers.FirstOrDefault(c => c.GetName() == customerName);
                var movie = Movies.FirstOrDefault(m => m.GetTitle() == movieTitle);

                if(customer!=null && movie !=null)
                {
                    customer.AddRental(new Rental(movie, daysRented));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"VideoRentalShop.AddRental() :An error occurred: {ex.Message}");
            }
        }

        public string GetCustomerStatement(string customerName)
        {
            string returnStatement = "";

            try
            {
                var customer = Customers.FirstOrDefault(c => c.GetName() == customerName);
                if (customer != null )
                {
                    returnStatement= customer.GetStatement();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"VideoRentalShop.GetCustomerStatement() :An error occurred: {ex.Message}");
            }
            return returnStatement;

        }
    }
}
