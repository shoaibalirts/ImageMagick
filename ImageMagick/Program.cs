namespace ImageMagick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MagickImage is running!");
            /*
            using (MagickImage image = new MagickImage(@"assets/mette.jpg"))
            {
                image.Resize(500, 0); // Resize til bredde 500, bevar aspekt
                image.Contrast();
                Directory.CreateDirectory("outputthumbnails");
                image.Write(@"outputthumbnails/mette_output.jpg");
                // Reading a single file
                var readingFolderImage = new MagickImageInfo(@"assets/mette.jpg");
                Console.WriteLine($"{readingFolderImage.Width} x {readingFolderImage.Height}");
                Console.WriteLine();
                // Reading multiple files from a folder
            }
            */
            string inputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\assets");
            string outputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\thumbnails");

            List<string> results = Thumbnailer.CreateThumbnails(inputFolder, outputFolder, 150);
            Console.WriteLine("Thumbnails created:");
            foreach (var thumb in results) 
            { 
                Console.WriteLine(thumb); 
            }


            Console.ReadKey();
        }
        
    }
}
