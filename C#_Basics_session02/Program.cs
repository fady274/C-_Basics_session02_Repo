namespace C__Basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("============== Q01 ==============");
            object B = Q01("Atomic Habits", 300);
            Console.WriteLine(B.ToString()); 

            Console.WriteLine("============== Q02 ==============");
            Q02(B);

            Console.WriteLine("============== Q03 ==============");
            Q03();

            Console.WriteLine("============== Q04 ==============");
            Q04();

            Console.WriteLine("============== Q05 ==============");
            Q05();

            Console.WriteLine("============== Q06 ==============");
            Q06();

            Console.WriteLine("============== Q07 ==============");
            Q07();

            Console.WriteLine("============== Q08 ==============");
            Q08();

            Console.WriteLine("============== Q09 ==============");
            Q09();

            Console.WriteLine("============== Q010 ==============");
            Q10();
            

        }




        #region Functions
        static Book Q01(string Title , int NPages)
        {
            Book B = new Book(Title, NPages);
            return B;
        }

        static void Q02(object B)
        {
            Console.WriteLine(B.ToString());
            Console.WriteLine(B.Equals(B));
            Console.WriteLine(B.GetHashCode());
            Console.WriteLine(B.GetType());
        }

        static void Q03()
        {
            // Compile Error
            bool check = int.TryParse("464" , out int res);
            Console.WriteLine(res);
        }

        static void Q04()
        {
            try
            {
                int y = 0;
                int x = 10 / y;
            }
            catch(DivideByZeroException E)
            {
                Console.WriteLine("Can not divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }

        static void Q05()
        {
            int pages = 300;
            double res = pages;
            Console.WriteLine(res.GetType());
        }

        static void Q06()
        {
            Double Price = 49.99;
            int res = (int)Price;
            Console.WriteLine(res);
        }

        static void Q07()
        {
            string pagesText = "464";
            int res = Convert.ToInt32 (pagesText);
            Console.WriteLine(res.GetType());
        }

        static void Q08()
        {
            string yearText = "2023";
            int res = int.Parse(yearText);
            Console.WriteLine(res.GetType());

            string badText = "abc";

            bool check = int.TryParse(badText, out int secresult);
            if (!check)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine(secresult);
            }

        }

        static void Q09()
        {
            int pages = 464;
            string res = pages.ToString();
            Console.WriteLine(res.GetType());
        }

        static void Q10()
        {
            int copies = 100;
            Object obj = copies;
            Console.WriteLine(obj);


            int res = (int)obj;
            Console.WriteLine(res);
        }
        #endregion
    }
}
