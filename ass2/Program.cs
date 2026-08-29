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
        }
    }
}
