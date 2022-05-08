using System;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Service
{
    public partial class ImageResize
    {
        private Image _image;

        public ImageResize(Image image)
        {
            _image = image;
        }

        public Bitmap Resize(Size side)
        {
            var resizedSide = CalcNewSide(side);
            var positon = CalcPosition(side, resizedSide);

            var resizedBitmap = new Bitmap(side.Width, side.Height);
            var graphic = Graphics.FromImage(resizedBitmap);
            ThumbGraphSettings(graphic);

            var rectangle = new Rectangle(positon, resizedSide);

            graphic.DrawImage(_image, rectangle);

            return resizedBitmap;
        }

        private Size CalcNewSide(Size side)
        {
            var maxSide = CalcMaxSide(side);
            decimal adjustment = _enlarge
                            ? Math.Max((decimal)maxSide.Width / _image.Width, (decimal)maxSide.Height / _image.Height)
                            : Math.Min((decimal)maxSide.Width / _image.Width, (decimal)maxSide.Height / _image.Height);

            return new Size()
            {
                Width = (int)Math.Round(_image.Width * adjustment),
                Height = (int)Math.Round(_image.Height * adjustment)
            };
        }

        private Size CalcMaxSide(Size side)
        {
            return new Size()
            {
                Width = Math.Min(side.Width, _image.Width),
                Height = Math.Min(side.Height, _image.Height)
            };
        }

        private Point CalcPosition(Size side, Size newSide)
        {
            return new Point()
            {
                X = Convert.ToInt32(side.Width * 0.5) - (newSide.Width / 2),
                Y = _alignTop ? 0 : Convert.ToInt32(side.Height * 0.5) - (newSide.Height / 2)
            };
        }

        private void ThumbGraphSettings(Graphics thumbGraph)
        {
            thumbGraph.Clear(Color.White);
            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

    }
}