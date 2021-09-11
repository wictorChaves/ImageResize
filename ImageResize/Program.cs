using System;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageResize
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var origem = "";
            var destino = "";

            Console.WriteLine("Entre com a largura");
            var largura = Console.ReadLine();

            Console.WriteLine("Entre com a altura");
            var altura = Console.ReadLine();

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                origem = fbd.SelectedPath;
            else
                Environment.Exit(0);

            if (fbd.ShowDialog() == DialogResult.OK)
                destino = fbd.SelectedPath;
            else
                Environment.Exit(0);


            Console.Write("Processando... ");
            foreach (var filePath in Directory.GetFiles(origem))
            {
                var img = Image.FromFile(filePath);
                var arrayPath = filePath.Split('\\');
                var fileName = largura + "x" + altura + "_" + arrayPath[arrayPath.Length - 1];
                ResizeImage(img, destino + "\\" + fileName, Convert.ToInt32(largura), Convert.ToInt32(altura));
            }
            Console.Write("Fim do processo");
            Console.ReadKey();
        }

        public static void ResizeImage(Image image, string targetPath, int Width, int Height, bool enlarge = false, bool alignTop = false)
        {
            decimal widthImage = image.Width;
            decimal heightImage = image.Height;

            if (widthImage >= heightImage)
                ResizeImageWidth(image, targetPath, Width, Height, widthImage, heightImage);
            else
                ResizeImageHeight(image, targetPath, Width, Height, widthImage, heightImage);
        }

        private static void ResizeImageHeight(Image image, string targetPath, int Width, int Height, decimal widthImage, decimal heightImage)
        {
            var percent = (100 * Height) / widthImage;

            var newWidth = Width;
            var newHeight = (int)Math.Round(heightImage * (percent / 100));

            var positionY = Convert.ToInt32(Height * 0.65) - (newHeight / 2);
            var positionX = 0;

            var thumbnailImg = new Bitmap(Width, Height);
            var thumbGraph = Graphics.FromImage(thumbnailImg);
            thumbGraph.Clear(Color.White);
            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            var imageRectangle = new Rectangle(positionX, positionY, newWidth, newHeight);

            thumbGraph.DrawImage(image, imageRectangle);
            thumbnailImg.Save(targetPath, image.RawFormat);
        }

        private static void ResizeImageWidth(Image image, string targetPath, int Width, int Height, decimal widthImage, decimal heightImage)
        {
            var percent = (100 * Height) / heightImage;

            var newWidth = (int)Math.Round(widthImage * (percent / 100));
            var newHeight = Height;

            var positionY = 0;
            var positionX = Convert.ToInt32(Width * 0.5) - (newWidth / 2);

            var thumbnailImg = new Bitmap(Width, Height);
            var thumbGraph = Graphics.FromImage(thumbnailImg);
            thumbGraph.Clear(Color.White);
            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            var imageRectangle = new Rectangle(positionX, positionY, newWidth, newHeight);

            thumbGraph.DrawImage(image, imageRectangle);
            thumbnailImg.Save(targetPath, image.RawFormat);
        }
    }
}
