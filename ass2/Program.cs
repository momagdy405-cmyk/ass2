using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ass2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Q1
            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print both title and upperTitle to show that title did not change.
            /*
             string title = "clean code";
             string uppertitle = title.ToUpper();
             Console.Write($"{title} {uppertitle}");
            */
            #endregion
            #region Q2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            /*
            string s01 = "clean code";
            string s02 = "clean code";
            Console.WriteLine(ReferenceEquals(s01, s02)); 
            */
            #endregion
            #region Q3,Q4
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.
            /*
            StringBuilder s01 = new StringBuilder();
            s01.Append("booklist");
            s01.Append("-updated");
            Console.Write(s01);
            s01.Replace("booklist", "library");
            Console.Write(s01);
            */
            #endregion
            #region Q5,Q6,Q7
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            /*
             //string title = "clean code";
             //int pages = 464;
            //Console.Write("Book:"+title+pages);
            //Console.WriteLine($"Book:{title}{pages}");
            //Console.WriteLine(string.Format("Book:{0},{1}",title,pages));
             */
            #endregion
            #region Q8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("largebook");
            //}
            //else
            //{
            //    Console.WriteLine("smallbook");
            //}
            #endregion
        }
    }
}
