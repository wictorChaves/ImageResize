using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var largura = "";
            var altura = "";

            var origem = "";
            var destino = "";

            Console.WriteLine("Entre com a largura");
            largura = Console.ReadLine();

            Console.WriteLine("Entre com a altura");
            altura = Console.ReadLine();

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                origem = fbd.SelectedPath;
            else
                Environment.Exit(0);


            if (fbd.ShowDialog() == DialogResult.OK)
                destino = fbd.SelectedPath;
            else
                Environment.Exit(0);


            Console.Write("Processando...");
            foreach (var filePath in Directory.GetFiles(origem))
            {
                var img = Image.FromFile(filePath);
                var arrayPath = filePath.Split('\\');
                var fileName = largura + "x" + altura + "_" + arrayPath[arrayPath.Length - 1];
                ResizeImage_n_save(img, destino + "\\" + fileName, Convert.ToInt32(largura), Convert.ToInt32(altura));
            }
            Console.Write("Fim do processo");
            Console.ReadKey();
        }


        public static void ResizeImage_n_save(Image image, string targetPath, int Width, int Height, bool enlarge = false, bool alignTop = false)
        {
            decimal widthImage = image.Width;
            decimal heightImage = image.Height;

            var maxWidth = Math.Min(Width, widthImage);
            var maxHeight = Math.Min(Height, heightImage);

            decimal adjustment = enlarge
                ? Math.Max(maxWidth / widthImage, maxHeight / heightImage)
                : Math.Min(maxWidth / widthImage, maxHeight / heightImage);

            var newWidth = (int)Math.Round(widthImage * adjustment);
            var newHeight = (int)Math.Round(heightImage * adjustment);

            var positionY = alignTop ? 0 : Convert.ToInt32(Height * 0.5) - (newHeight / 2);
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
