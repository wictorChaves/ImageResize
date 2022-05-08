using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class ImageResize
    {
        private bool _enlarge = false;
        private bool _alignTop = false;
        
        public ImageResize Enlarge()
        {
            _enlarge = true;
            return this;
        }

        public ImageResize Unstretch()
        {
            _enlarge = false;
            return this;
        }

        public ImageResize AlignTop()
        {
            _alignTop = false;
            return this;
        }

        public ImageResize AlignCenter()
        {
            _alignTop = false;
            return this;
        }
    }
}
