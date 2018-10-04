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
                new PricingRule(typeof(A)),
                new PricingRule(typeof(B), 2, 20.0 / 12.0),
                new PricingRule(typeof(C), 3, 10.0 / 4.0),
                new PricingRule(typeof(D), 2, 1),
                new PricingRule(typeof(E), 3, 2)
            };

        static void Main(string[] args)
        {
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
