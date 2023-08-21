namespace VideoRental
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        private string Name;

        private List<Rental> Rentals = new List<Rental>();

        public void AddRental(Rental rental)
        {
            try
            {
                Rentals.Add(rental);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer.AddRental() :An error occurred: {ex.Message}");
            }
        }

        public string GetName() 
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer.GetName() :An error occurred: {ex.Message}");
            }
            return Name; 
        }
        public void SetName(string name)
        {
            try
            {
                Name = name;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer.SetName() :An error occurred: {ex.Message}");
            }
        }

        public string GetStatement()
        {
            StringBuilder result = new StringBuilder();

            try
            {
                double totalAmount = 0.0;
                int frequentRenterPoints = 0;
                result.AppendLine("Rental Record for" + GetName());

                foreach (var rental in Rentals)
                {
                    double thisAmount = 0.0;


                    // Add frequent renter points
                    frequentRenterPoints++;

                    // Add bonus for a two day new release rental
                    if ((rental.GetMovie().GetPriceCode() == Movie.EnumPriceCode.NEW_RELEASE)
                            && rental.GetDaysRented() > 1) frequentRenterPoints++;

                    // Show figures for this rental
                    result.AppendLine("\t" + rental.GetMovie().GetTitle() + "\t" + rental.GetRentalPrice());
                    totalAmount += thisAmount;
                }

                result.AppendLine("Amount owed is " + totalAmount);
                result.AppendLine("You earned " + frequentRenterPoints + " frequent renter points");

                foreach (var retal in Rentals)
                {
                    result.AppendLine(GetRentalInformation(retal));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer.GetStatement() :An error occurred: {ex.Message}");
            }
           
            return result.ToString();
        }

        public string GetRentalInformation(Rental rental)
        {
            string returnInformation = null;
            try
            {
                if (rental != null && rental.GetMovie() != null)
                {
                    returnInformation = $"{rental.GetMovie().GetPriceCode()}\t {rental.GetMovie().GetTitle()}\t {rental.GetDaysRented()} \t {rental.GetRentalPrice()}";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Customer.GetRentalInformation() :An error occurred: {ex.Message}");
            }
            return returnInformation;
        }

       
    }
}
