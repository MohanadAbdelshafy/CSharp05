namespace C_05
{
    #region Question 1 book class
    //class Book
    //{
    //    private string password = "secret";
    #region Question 2 Internal feild
    //internal int copiesInStock = 5;
    #endregion
    #region Question 3 Public feild
    //public string Title;
    #endregion
    #region Question 4 Enum property
    //public Genre Genre { get; set; }
    #endregion
    //}
    #endregion
    #region Question 4 Enum
    //enum Genre
    //{
    //    Fiction,NonFiction, Science
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 object creating
            //Book b = new Book();
            //Console.WriteLine(b.password);
            ////compile time error,because the password feild is protected (can't access outside the class) 
            #endregion
            #region Question 2
            //Book b = new Book();
            //Console.WriteLine(b.copiesInStock);
            ////yes it does,Because the internal feild is accessible trhought the same assembly 
            #endregion
            #region Question 3
            //Book b=new Book();
            //b.Title = "Mohanad";
            //Console.WriteLine(b.Title);
            #endregion
            #region Question 4
            //Book b = new Book();
            //b.Genre = Genre.Science;
            //Console.WriteLine(b.Genre);
            #endregion
            #region Question 5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion
            #region Question 6
            //int genreNumber = 1;
            //Genre g = (Genre)genreNumber;
            //Console.WriteLine(g);
            #endregion
            #region Question 7
            //Genre genre = Genre.Fiction;
            //string gtext = genre.ToString();
            //Console.WriteLine(gtext);
            #endregion
            #region Question 8
            //string genreText = "Science";
            //Genre g = (Genre)Enum.Parse(typeof(Gener),genreText);
            //Console.WriteLine(g);
            #endregion
            #region Question 9
            //string genreText = "Mystery";

            //if (Enum.TryParse<Genre>(genreText, out Genre g))
            //    Console.WriteLine(g);
            //else
            //    Console.WriteLine("Unknown genre");
            #endregion
        }
    }
}
