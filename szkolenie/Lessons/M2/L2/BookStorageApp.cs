namespace course_alx.Lessons.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            var storageService = new BookStorageService();
            Console.WriteLine("Service book :");
            Console.WriteLine();
            CreateBook(storageService);
        }

        public static void CreateBook(BookStorageService service)
        {
            //var book = new Book
        }

    }
}
