using System;
using ImageMagick;
using timeline_server_dotnet_data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.IO;

// https://www.nuget.org/packages/Magick.NET-Q8-x64/
// https://github.com/dlemstra/Magick.NET/
// https://imagemagick.org/Usage/resize/
// dotnet add package Magick.NET-Q8-x64 --version 7.15.4

namespace image_Resize
{
    public class ImageResize
    {
        private PartsCatalogDbContext db;

        public ImageResize()
        {
            var contextBuilder = new DbContextOptionsBuilder<PartsCatalogDbContext>();
            contextBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LegoCatalog;Trusted_Connection=True;");
            db = new PartsCatalogDbContext(contextBuilder.Options);
        }

        public void ResizeSetOfLegoImages(int totalImagesToConvert = 100)
        {
            string LegoImagesWriteLocation = "f:\\LegoImages";

            foreach (var part in db.Parts.Where(p => string.IsNullOrWhiteSpace(p.IconLink)).Take(totalImagesToConvert).ToList())
            {
                byte[] imageBytes;
                string imageFilename = $"{part.ItemId}.png";

                try
                {
                    using (var webClient = new WebClient())
                    {
                        imageBytes = null;
                        imageBytes = webClient.DownloadData(part.ImageLink);
                    }

                    if (imageBytes != null)
                    {
                        MagickImage image = new MagickImage(imageBytes);

                        var geometry = new MagickGeometry();
                        image.Resize(100, 100);

                        image.Format = MagickFormat.Png;
                        image.Write(Path.Combine(LegoImagesWriteLocation, $"{part.ItemId}.png"));

                        part.IconLink = imageFilename;
                        db.SaveChanges();

                        Console.WriteLine($"Converted image to {part.ItemId}.png");
                    }
                }
                catch (Exception ex)
                {
                    part.IconLink = "error";
                    db.SaveChanges();

                    Console.WriteLine($"Error resizing image {imageFilename} from {part.ImageLink}: {ex.Message}");
                }
            }
        }

        private void ResizeImage(string filename)
        {
            using (MagickImage image = new MagickImage("filename.png"))
            {
                MagickGeometry size = new MagickGeometry(100, 100);
                // This will resize the image to a fixed size without maintaining the aspect ratio.
                // Normally an image will be resized to fit inside the specified size.
                size.IgnoreAspectRatio = true;

                image.Resize(size);

                // Save the result
                image.Write("C:/output/" + "Snakeware.100x100.png");
            }

        }
    }


}
