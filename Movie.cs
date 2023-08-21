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
            SetPriceCode(priceCode);
        }

        private string Title=null;
        private EnumPriceCode PriceCode = EnumPriceCode.REGULAR;
        private IRentalPrice RentalPrice = null;

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
            SetRentalPrice(priceCode);
        }
        public IRentalPrice GetRentalPrice()
        {
            return RentalPrice;
        }
        private void SetRentalPrice(EnumPriceCode priceCode)
        {
            switch (priceCode)
            {
                case EnumPriceCode.REGULAR:
                    RentalPrice = new RegularPrice();
                    break;
                case EnumPriceCode.NEW_RELEASE:
                    RentalPrice = new NewReleasePrice();
                    break;
                case EnumPriceCode.CHILDRENS:
                    RentalPrice = new ChildrensPrice();
                    break;
                case EnumPriceCode.EXAMPLE_GENRE:
                    RentalPrice = new ExampleGenrePrice();
                    break;
                default:
                    break;
            }
        }

    }

    public interface IRentalPrice
    {
        double CalculatePrice(int daysRented);
    }

    public class RegularPrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            double price = 2;
            if (daysRented > 2)
            {
                price += (daysRented - 2) * 1.5;
            }
            return price;
        }
    }

    public class NewReleasePrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            return daysRented * 3;
        }
    }

    public class ChildrensPrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            double price = 1.5;
            if (daysRented > 3)
            {
                price += (daysRented - 3) * 1.5;
            }
            return price;
        }
    }

    public class ExampleGenrePrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            double price = 1.5 * daysRented;
          
            return price;
        }
    }
}
