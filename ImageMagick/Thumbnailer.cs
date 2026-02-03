using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMagick
{
    public class Thumbnailer
    {
        public static List<string> CreateThumbnails(string inputFolder, string outputFolder, int width=150)
        {
            List<string> thumbnails = new List<string>();
            foreach(var file in Directory.GetFiles(inputFolder))
            {
                var info = new MagickImageInfo(file);
                Console.WriteLine($"Found {Path.GetFileName(file)} ({info.Width}x{info.Height})");
                using(var image = new MagickImage(file))
                {
                    image.Resize((uint)width, 0);
                    string outputPath = Path.Combine(outputFolder, Path.GetFileName(file));
                    image.Write(outputPath);
                    thumbnails.Add(outputPath);
                }
            }
            return thumbnails;
        }
    }
}
