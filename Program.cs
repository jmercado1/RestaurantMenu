using System;
using System.Collections.Generic;
class Menu 
{
    string appetizer;
    string maincourse;
    string dessert;

    public string Appetizer
    {
        get { return appetizer; }
        set { appetizer = value; }
    }

    public string MainCourse
    {
        get { return maincourse; }
        set { maincourse = value; }
    }

    public string Dessert
    {
        get { return dessert; }
        set { dessert = value; }
    }

    class MenuItem
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Appetizer = "Chicken Tenders";
            menu.MainCourse = "Hamburger";
            menu.Dessert = "Chocolate Cake";

            System.Console.WriteLine("Appetizer (New Item) \n$12");
            System.Console.WriteLine("Try our signature chicken tenders voted best in town!");

            System.Console.WriteLine("Main Course \n$15");
            System.Console.WriteLine("The infamous Johnny burger known for being 3000 calories is our most popular item!");

            System.Console.WriteLine("Dessert \n$9");
            System.Console.WriteLine("Our classic chocolate cake that competes with the signature chains across the nation!");

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
        }
    }
}