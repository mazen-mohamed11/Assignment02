using System;
using System.Text;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Q1
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q2
            string s01 = "Clean Code";
            string s02 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(s01, s02));
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q3
            StringBuilder sb01 = new StringBuilder("Book List");
            sb01.Append(" - Updated");
            Console.WriteLine(sb01);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q4
            sb01.Replace("Book List", "Library");
            Console.WriteLine(sb01);
            Console.WriteLine("---------------------------------");
            #endregion
            //Q5
            #region
            string titleName01 = "Clean Code";
            int pages01 = 464;
            Console.WriteLine("Book : " + titleName01 + " , " + "Pages : " + pages01);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q6
            string titleName02 = "Clean Code";
            int pages02 = 464;
            Console.WriteLine($"Book : {titleName02} , Pages : {pages02}");
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q7
            string titleName03 = "Clean Code";
            int pages03 = 464;
            Console.WriteLine(string.Format("Book : {0} , Pages : {1}", titleName03, pages03));
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q8
            int pages001 = 464;
            if (pages001 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q9
            int pages002 = 464;
            bool isAvailable = true;
            if (pages002 > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("I am sorry , this book is not available now");
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q10
            string titleName = "Refactoring";
            switch (titleName)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q11
            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q12
            string[] books01 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books01.Length; i++)
            {
                Console.WriteLine(i+1 + "." + books01[i]);
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q13
            string[] books02 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int x = 0; 
            while (x < books02.Length)
            {
                Console.WriteLine(x+1 + "." + books02[x]);
                x++;
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q14
            int y = 0;
            do
            {
                Console.WriteLine("Checking book...");
                y++;
            } while (y < 3);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q15
            string[] books03 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books03)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q16
            string[] books04 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int j = 0; j < books04.Length; j++)
            {
                if(books04[j]== "Refactoring")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(j + 1 + "- " + books04[j]);
                }
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q17
            string[] books05 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int j = 0; j < books05.Length; j++)
            {
                if (books05[j] == "The Pragmatic Programmer")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(j + 1 + "/" + books05[j]);
                }
            }
            Console.WriteLine("---------------------------------");
            #endregion
            //Q18
            string[] books06 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            void PrintFirstBook()
            {
                if (books06.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books06[0]);
            }
            PrintFirstBook();

        }
    }
}
