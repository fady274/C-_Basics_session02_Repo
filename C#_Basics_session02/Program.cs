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



        }

    }
}
