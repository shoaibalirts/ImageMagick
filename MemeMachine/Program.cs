using ImageMagick;
using ImageMagick.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace MemeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meme Machine!");
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\assets\");            //string filePath = Path.Combine(path1,"cat1.jpg");
            string filePath = Path.Combine(path1, "mette.jpg");
            Console.WriteLine("Looking for: " + Path.GetFullPath(filePath)); 
            Console.WriteLine(File.Exists(filePath) ? "Found!" : "Not found!");
            if (!File.Exists(filePath)) {
                Console.WriteLine("File not found.");
                Console.ReadKey();
                return;
            }
            

            string imageFileFullPath = Path.GetFullPath(filePath);
             Console.WriteLine("{0}'",imageFileFullPath); // path of cat1.jpg

            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(text)) 
            { 
                Console.WriteLine("No text entered."); 
            }
            else { 

                using (MagickImage image = new MagickImage(imageFileFullPath))
                {
                    /*
                    var settings = new Drawables()
                                        .Font("Arial")
                                        .FontPointSize(36)
                                        .FillColor(MagickColors.Red)
                                        .TextAlignment(TextAlignment.Center); 
                                    settings.Text(100, 100, text); 
                                    image.Draw(settings);
                                    image.Write(@"C:\Users\engrs\Desktop\ProCsharp\ImageMagick\MemeMachine\assets\mette_output.jpg");
                    */
                    image.Settings.Font = "Arial";
                    image.Settings.BackgroundColor = MagickColors.Transparent;
                    image.Settings.FillColor = MagickColors.Red;

                    image.Annotate(text, Gravity.South);
                    image.Write(@"C:\Users\engrs\Desktop\ProCsharp\ImageMagick\MemeMachine\assets\mette_output.jpg");
                }
            }
            Console.WriteLine("Enter any key to exit the program...");
            Console.ReadKey();
        }
    }
}
