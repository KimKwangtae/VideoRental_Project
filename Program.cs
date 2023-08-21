namespace VideoRental
{
    using System;
  

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VideoRentalShop rentalShop = new VideoRentalShop("비디오렌탈샵");
                rentalShop.AddMovie("일반 1", Movie.EnumPriceCode.REGULAR);
                rentalShop.AddMovie("일반 2", Movie.EnumPriceCode.REGULAR);
                rentalShop.AddMovie("신작 1", Movie.EnumPriceCode.NEW_RELEASE);
                rentalShop.AddMovie("신작 2", Movie.EnumPriceCode.NEW_RELEASE);
                rentalShop.AddMovie("어린이 1", Movie.EnumPriceCode.CHILDRENS);
                rentalShop.AddMovie("어린이 2", Movie.EnumPriceCode.CHILDRENS);
                rentalShop.AddMovie("새로운장르 1", Movie.EnumPriceCode.EXAMPLE_GENRE);
                rentalShop.AddCustomer("고객");


                rentalShop.AddRental("고객", "일반 1", 2);
                rentalShop.AddRental("고객", "일반 2", 3);
                rentalShop.AddRental("고객", "신작 1", 1);
                rentalShop.AddRental("고객", "신작 2", 2);
                rentalShop.AddRental("고객", "어린이 1", 3);
                rentalShop.AddRental("고객", "어린이 2", 4);
                rentalShop.AddRental("고객", "새로운장르 1", 1);

                Console.Write(rentalShop.GetCustomerStatement("고객"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Program.Main() :An error occurred: {ex.Message}");
            }
        }
    }
}
