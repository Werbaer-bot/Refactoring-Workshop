var discMan = new DiscountManager.DiscMan();
Console.WriteLine("Discount for 100 items for Not Registered Customer with 1 year loyality: " + discMan.Calculate(100,1,1));
Console.WriteLine("Discount for 50 items for Simple Customer with 2 year loyality: " + discMan.Calculate(50,2,2));
Console.WriteLine("Discount for 42 items for Valuable Customer with 3 year loyality: " + discMan.Calculate(42,3,3));
Console.WriteLine("Discount for 99 items for Most Valuable Customer with 5 year loyality: " + discMan.Calculate(99,4,5));
