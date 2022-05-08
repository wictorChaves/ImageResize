using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.CLI
{
    public class FillParameters
    {
        public Size? Size { get; set; } = null;
        public string Input { get; set; }
        public string Output { get; set; }
        public bool Enlarge { get; set; } = false;
        public bool AlignTop { get; set; } = false;

        public string GetValue(string paramenter)
        {
            return paramenter.Split('=')[1];
        }

        public void SetSize(string paramenter)
        {
            var value = GetValue(paramenter);
            var values = value.Split('x');
            int width = Int32.Parse(values[0]);
            int height = Int32.Parse(values[1]);
            Size = new Size() { Width = width, Height = height };
        }

        public void SetInput(string paramenter)
        {
            Input = GetValue(paramenter);
        }

        public void SetOutput(string paramenter)
        {
            Output = GetValue(paramenter);
        }

        public void SetEnlarge()
        {
            Enlarge = true;
        }

        public void SetAlignTop()
        {
            AlignTop = true;
        }

        public string MessageError()
        {
            if (Size == null)
            {
                return "Size is required";
            }
            if (Input == null)
            {
                return "Input is required";
            }
            if (Output == null)
            {
                return "Output is required";
            }
            return null;
        }
    }
}
