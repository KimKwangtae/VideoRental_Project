namespace VideoRental
{
    using System;
  

    public class Program
    {
        static void Main(string[] args)
        {
            Movie regular1 = new Movie("일반 1", Movie.EnumPriceCode.REGULAR);
            Movie regular2 = new Movie( "일반 2", Movie.EnumPriceCode.REGULAR);
            Movie newRelease1 = new Movie( "신작 1", Movie.EnumPriceCode.NEW_RELEASE);
            Movie newRelease2 = new Movie( "신작 2",Movie.EnumPriceCode.NEW_RELEASE);
            Movie children1 = new Movie( "어린이 1", Movie.EnumPriceCode.CHILDRENS);
            Movie children2 = new Movie( "어린이 2", Movie.EnumPriceCode.CHILDRENS);
            Movie exampleGenre = new Movie("새로운장르 1", Movie.EnumPriceCode.EXAMPLE_GENRE);
            Customer customer = new Customer("고객");

            customer.AddRental(new Rental( regular1, 2 ));
            customer.AddRental(new Rental( regular2, 3 ));
            customer.AddRental(new Rental( newRelease1, 1 ));
            customer.AddRental(new Rental( newRelease2, 2 ));
            customer.AddRental(new Rental( children1, 3 ));
            customer.AddRental(new Rental( children2, 4 ));
            customer.AddRental(new Rental(exampleGenre, 1));

            Console.Write(customer.GetStatement());
        }
    }
}
