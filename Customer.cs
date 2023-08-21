namespace VideoRental
{
    using System.Collections.Generic;
    using System.Text;

    class Customer
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


            IEnumerator<Rental> enumerator = Rentals.GetEnumerator();

            for (; enumerator.MoveNext();)
            {
                double thisAmount = 0.0;
                Rental each = enumerator.Current;

                switch (each.GetMovie().GetPriceCode())
                {
                    case Movie.REGULAR:
                        thisAmount += 2.0;
                        if (each.GetDaysRented() > 2)
                            thisAmount += (each.GetDaysRented() - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.GetDaysRented() * 3;
                        break;

                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.GetDaysRented() > 3)
                            thisAmount += (each.GetDaysRented() - 3) * 1.5;
                        break;
                }
                each.GetMovie().SetRentalPrice(thisAmount);
                // Add frequent renter points
                frequentRenterPoints++;

                // Add bonus for a two day new release rental
                if ((each.GetMovie().GetPriceCode() == Movie.NEW_RELEASE)
                        && each.GetDaysRented() > 1) frequentRenterPoints++;

                // Show figures for this rental
                result.AppendLine("\t" + each.GetMovie().GetTitle() + "\t" + thisAmount.ToString());
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
                returnInformation = $"{rental.GetMovie().GetPriceCode()}\t {rental.GetMovie().GetTitle()}\t {rental.GetDaysRented()} \t {rental.GetMovie().GetRentalPrice()}"; 
            }

            return returnInformation;
        }

       
    }
}
