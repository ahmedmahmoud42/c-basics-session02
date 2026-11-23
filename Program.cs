using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;

namespace Assignment1
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.

            object book = new Book { Title = "Science", Pages = 123 };
            Console.WriteLine(book);

            #endregion#

            #region Question 2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book
            Console.WriteLine(book.ToString());    //Assignment1.Book
            Console.WriteLine(book.Equals(book));  // True
            Console.WriteLine(book.GetType());     // Assignment1.Book
            Console.WriteLine(book.GetHashCode()); // 12479570
            #endregion

            #region Question 3
            // Look at the line => int pages = "464"; .  Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int Pages ="124"; // compile-time error
            int Pages = 124;

            #endregion

            #region Question 4
            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            int x = 10;
            int y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Cannot Divide By Zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion

            #region Question 5
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages = 300;
            double var = pages;
            Console.WriteLine(var);

            #endregion

            #region Question 6
            // Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int n = (int)price;
            Console.WriteLine(n);

            #endregion

            #region Question 7
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int res = Convert.ToInt32(pagesText);
            Console.WriteLine(res); // 464

            #endregion

            #region Question 8
            // Given string yearText = "2023";, convert it using int.Parse().
            // Then given string badText = "abc";, use int.TryParse() to safely try converting it,
            // and print "Invalid number" if it fails.

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year); // 2023

            string badText = "abc";
            bool text = int.TryParse(badText, out int y);
            if (text)
                Console.WriteLine("Valid Numvber");
            else
                Console.WriteLine("InValid Numvber"); // Will Occurs
            #endregion

            #region Question 9
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string
            int pagess = 464;
            string num = pagess.ToString();
            Console.WriteLine(num);           // 464
            Console.WriteLine(num.GetType()); // System.String

            #endregion

            #region Question 10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            int copies = 100;            
            object obj = copies;    // Boxing
            Console.WriteLine(obj); // 100

            int newInt = (int)obj;     // UnBoxing
            Console.WriteLine(newInt); // 100
            #endregion



        }
    }
}
