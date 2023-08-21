
namespace VideoRental
{
    using System;

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
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.GetTitle() :An error occurred: {ex.Message}");
            }
            return Title;
        }
        public void SetTitle(string title)
        {
            try
            {
                Title = title;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.SetTitle() :An error occurred: {ex.Message}");
            }
        }

        public EnumPriceCode GetPriceCode() 
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.PriceCode() :An error occurred: {ex.Message}");
            }
            return PriceCode; 
        }
        public void SetPriceCode(EnumPriceCode priceCode)
        {
            try
            {
                PriceCode = priceCode;
                SetRentalPrice(priceCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.SetPriceCode() :An error occurred: {ex.Message}");
            }
        }
        public IRentalPrice GetRentalPrice()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.GetRentalPrice() :An error occurred: {ex.Message}");
            }
            return RentalPrice;
        }
        private void SetRentalPrice(EnumPriceCode priceCode)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine($"Movie.SetRentalPrice() :An error occurred: {ex.Message}");
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
            try
            {
                if (daysRented > 2)
                {
                    price += (daysRented - 2) * 1.5;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"RegularPrice.CalculatePrice() :An error occurred: {ex.Message}");
            }
            return price;
        }
    }

    public class NewReleasePrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"NewReleasePrice.CalculatePrice() :An error occurred: {ex.Message}");
            }
            return daysRented * 3;
        }
    }

    public class ChildrensPrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            double price = 1.5;
            try
            {
                if (daysRented > 3)
                {
                    price += (daysRented - 3) * 1.5;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ChildrensPrice.CalculatePrice() :An error occurred: {ex.Message}");
            }
            return price;
        }
    }

    public class ExampleGenrePrice : IRentalPrice
    {
        public double CalculatePrice(int daysRented)
        {
            double price = 1.5 * daysRented;
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ExampleGenrePrice.CalculatePrice() :An error occurred: {ex.Message}");
            }
            return price;
        }
    }
}
