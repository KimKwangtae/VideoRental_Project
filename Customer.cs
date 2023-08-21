namespace VideoRental
{
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
            Rentals.Add(rental); 
        }

        public string GetName() 
        { 
            return Name; 
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetStatement()
        {
            double totalAmount = 0.0;
            int frequentRenterPoints = 0;
            StringBuilder result = new StringBuilder();

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

            foreach(var retal in Rentals)
            {
                result.AppendLine(GetRentalInformation(retal));
            }
            return result.ToString();
        }

        public string GetRentalInformation(Rental rental)
        {
            string returnInformation = null;
            if(rental!=null&&rental.GetMovie()!=null)
            {
                returnInformation = $"{rental.GetMovie().GetPriceCode()}\t {rental.GetMovie().GetTitle()}\t {rental.GetDaysRented()} \t {rental.GetRentalPrice()}"; 
            }

            return returnInformation;
        }

       
    }
}
