/*
 * Created by TILMAN RAENDCHEN for UNiDAYS Internship Tech Placements 2019-2020 Application Coding Challenge
 * 
 * GitHub: https://github.com/medallyon
 * LinkedIn: https://www.linkedin.com/in/tilmanraendchen
 * For enquiries, contact mailto://traendchen@outlook.com
 * 
 * All tests replicate the ones on the GitHub Coding Challenge page: https://github.com/MyUNiDAYS/tech-placements-19-20
 * Thank you for taking the time to read and test this solution.
 */

using System;

namespace UNiDAYS_Challenge
{
    class Program
    {
        // Create a default rule-table to be used throughout for testing
        public static PricingRules DefaultRules = new PricingRules
            {
                // No discount
                new PricingRule(typeof(A)),
                // Discount for £20 if 2 items exist
                new PricingRule(typeof(B), 2, 20.0 / 12.0),
                // Discount for £10 if 3 items exist
                new PricingRule(typeof(C), 3, 10.0 / 4.0),
                // Discount for £7 (same price) if 2 items exist
                new PricingRule(typeof(D), 2, 1),
                // Discount for £10 (3 for 2) if 3 items exist
                new PricingRule(typeof(E), 3, 2)
            };

        // This demo represents the example found on the github readme
        // and shows how this interface can be implemented
        static void InterfaceDemo()
        {
            UnidaysDiscountChallenge challenge = new UnidaysDiscountChallenge(Program.DefaultRules);

            Item itemOne = new A(5);
            Item itemTwo = new B(12);

            challenge.AddToBasket(itemOne);
            challenge.AddToBasket(itemTwo);

            PriceResult result = challenge.CalculateTotalPrice();

            double totalPrice = result.Total;
            double deliveryCharge = result.DeliveryCharge;
            double overallTotal = totalPrice + deliveryCharge;
        }

        static void Main(string[] args)
        {
            Console.Write("Welcome to this solution (created by Tilman Raendchen for myUNiDAYS coding challenge)." +
                "\nSimply press [ RETURN ] to start the test cases...");
            Console.ReadLine();

            // Uncomment the next line to run through the interface demo
            //Program.InterfaceDemo();
            Program.RunTestCases();

            Console.Write("\n\nThis demo is now finished. Press [ RETURN ] to exit...");
            Console.ReadLine();
        }

        static void RunTestCases()
        {
            (new TestCase(new Basket { })).Run();

            (new TestCase(new Basket
            {
                new A()
            })).Run();

            (new TestCase(new Basket
            {
                new B()
            })).Run();

            (new TestCase(new Basket
            {
                new C()
            })).Run();

            (new TestCase(new Basket
            {
                new D()
            })).Run();

            (new TestCase(new Basket
            {
                new E()
            })).Run();

            (new TestCase(new Basket
            {
                new B(),
                new B()
            })).Run();

            (new TestCase(new Basket
            {
                new B(),
                new B(),
                new B()
            })).Run();

            (new TestCase(new Basket
            {
                new B(),
                new B(),
                new B(),
                new B()
            })).Run();

            (new TestCase(new Basket
            {
                new C(),
                new C(),
                new C()
            })).Run();

            (new TestCase(new Basket
            {
                new C(),
                new C(),
                new C(),
                new C()
            })).Run();

            (new TestCase(new Basket
            {
                new D(),
                new D()
            })).Run();

            (new TestCase(new Basket
            {
                new D(),
                new D(),
                new D()
            })).Run();

            (new TestCase(new Basket
            {
                new E(),
                new E()
            })).Run();

            (new TestCase(new Basket
            {
                new E(),
                new E(),
                new E()
            })).Run();

            (new TestCase(new Basket
            {
                new E(),
                new E(),
                new E(),
                new E()
            })).Run();

            (new TestCase(new Basket
            {
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D(),
                new D()
            })).Run();

            (new TestCase(new Basket
            {
                new B(),
                new B(),
                new B(),
                new B(),
                new C(),
                new C(),
                new C()
            })).Run();

            (new TestCase(new Basket
            {
                new A(),
                new B(),
                new B(),
                new C(),
                new C(),
                new C(),
                new D(),
                new D(),
                new E(),
                new E()
            })).Run();

            (new TestCase(new Basket
            {
                new E(),
                new D(),
                new C(),
                new B(),
                new A(),
                new E(),
                new D(),
                new C(),
                new B(),
                new C()
            })).Run();
        }
    }
}
