namespace ImageMagick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MagickImage is running!");
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
                // Reading multiple files


            }

            Console.ReadKey();
        }
        
    }
}
