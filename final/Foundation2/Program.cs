using System;

class Program
{
    static void Main(string[] args)
    
    {
        //customer 1 address
        Address address1 = new Address("15 Hamdan St","Abuzabi", "Abu Dhabi","United Arab Emirate" );//street, city, state, country

        //customer 1 name and address        
        Customer customer1 = new Customer ("Joseph Israel", address1);//name and  Address


        //customer 1 orders
        Product product1 = new Product("Closet", 005, 965.66, 4); //Name,productId,Price,Quantiy

        Product product2 = new Product("Kichen Cabinet", 096, 254.00, 2); //Name,productId,Price,Quantity

        Product product3 = new Product("Sliding Doors", 657, 100.68, 1); //Name,productId,Price,Quantity


        //customer 2 address
        Address address2 = new Address("65 Kalifa Park St","BurDahabi", "Dubai","United Arab Emirate" );//street, city, state, country

        //customer 2 name and address        
        Customer customer2 = new Customer ("Mohamed", address2);//name and  Address


        //customer 2 orders
        Product p1 = new Product("Headphone", 055, 9.66, 6); //Name,productId,Price,Quantiy

        Product p2 = new Product("Phone Cover", 076, 27.00, 25); //Name,productId,Price,Quantity

        Product p3 = new Product("Phone Charger", 802, 14.68, 7); //Name,productId,Price,Quantity


        //customer 3 address
        Address address3 = new Address("65 Kingston St","NewValle", "Utah","USA" );//street, city, state, country

        //customer 2 name and address       
        Customer customer3 = new Customer ("Mohamed", address3);//name and  Address


        //customer 3 orders
        Product c1 = new Product("Books", 065, 8.66, 8); //Name,productId,Price,Quantiy

        Product c2 = new Product("Pen", 086, 65.00, 75); //Name,productId,Price,Quantity

        Product c3 = new Product("white Boards", 76, 14.68, 7); //Name,productId,Price,Quantity        


      
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        Order order2 = new Order(customer2);
        order2.AddProduct(p1);
        order2.AddProduct(p2);
        order2.AddProduct(p3);

        Order order3 = new Order(customer3);
        order3.AddProduct(c1);
        order3.AddProduct(c2);
        order3.AddProduct(c3);




        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine($"Order 2 Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();


        Console.WriteLine($"Order 3 Total Cost: ${order3.GetTotalCost()}");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());

        Console.WriteLine();



    
    }
}
