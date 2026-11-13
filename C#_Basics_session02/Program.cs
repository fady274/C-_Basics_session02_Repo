using System.Drawing;
using System.Dynamic;

namespace C__Basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.

            Console.WriteLine("============== Q01 ==============");
            object B = new Book("C# Basics", 464);
            Console.WriteLine(B.ToString());

            #endregion

            #region Q02
            // Q02.Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine(B.ToString());
            Console.WriteLine(B.Equals(B));
            Console.WriteLine(B.GetHashCode());
            Console.WriteLine(B.GetType());

            #endregion

        }

    }
}
