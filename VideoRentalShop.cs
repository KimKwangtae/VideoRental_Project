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
            Movies.Add(new Movie(title, priceCode));
        }
        public void AddCustomer(string customerName)
        {
            Customers.Add(new Customer(customerName));
        }
        public void AddRental(string customerName,string movieTitle,int daysRented)
        {
            var customer=Customers.FirstOrDefault(c => c.GetName() == customerName);
            var movie = Movies.FirstOrDefault(m => m.GetTitle() == movieTitle);

            if(customer!=null && movie !=null)
            {
                customer.AddRental(new Rental(movie, daysRented));
            }
        }

        public string GetCustomerStatement(string customerName)
        {
            string returnStatement = "";
            var customer = Customers.FirstOrDefault(c => c.GetName() == customerName);
            if (customer != null )
            {
                returnStatement= customer.GetStatement();
            }
            return returnStatement;
        }
    }
}
