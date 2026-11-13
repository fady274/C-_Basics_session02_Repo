using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Timers;

namespace C__Basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.

            //Console.WriteLine("============== Q01 ==============");
            //object B = new Book("C# Basics", 464);
            //Console.WriteLine(B.ToString());

            #endregion

            #region Q02
            // Q02.Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            //Console.WriteLine(B.ToString());
            //Console.WriteLine(B.Equals(B));
            //Console.WriteLine(B.GetHashCode());
            //Console.WriteLine(B.GetType());

            #endregion

            #region Q03
            //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            // Compile Error
            //bool check = int.TryParse("464", out int res);
            //Console.WriteLine(res);
            #endregion

            #region Q04
            //Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.

            try
            {
                int y = 0;
                int x = 10 / y;
            }
            catch (DivideByZeroException E)
            {
                Console.WriteLine("Can not divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion



        }

    }
}
