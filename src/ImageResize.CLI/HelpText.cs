using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.CLI
{
    public class HelpText
    {
        public static string TEXT = @"
Image Resize CLI Help

    --side
    Set the dimension of the new image
    Example:
    	--side=1366x768
    	
    --input
    Input file path
    Example:
    	--input=""C:\temp\teste.jpg""
    	
    --output
    Output file path
    Example:
    	--output=""C:\temp\teste_output.jpg""
    	
    --enlarge
    The image is centered and loses edges to fill the entire size of the new image
    Example:
    	--enlarge
    	
    --aligntop
    Align the image to the top and no longer to the center
    Example:
    	--aligntop";

    }
}
