namespace MemeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meme Machine!");
            string file1 = "cat1.jpg";
            string path1 = @"assets";
            string imageFileFullPath;
            //imageFileFullPath = Path.GetFullPath(path1);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'", path1, imageFileFullPath);
            imageFileFullPath = Path.GetFullPath(file1);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'", path1, imageFileFullPath); // path of cat1.jpg

            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("You entered: "+text);
            using (var imageToBeLoaded = new MagicImage(imageFileFullPath))
            {

            }
            Console.WriteLine("Enter any key to exit the program...");
            Console.ReadKey();
        }
    }
}
