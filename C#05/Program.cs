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
        }
    }
}
