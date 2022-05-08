using Service;
using System.Drawing;

var path = @"Images\Input\horizontal.jpg";
var image = Image.FromFile(path);
new ImageResize(image)
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\horizontal.jpg", image.RawFormat);

path = @"Images\Input\vertical.jpg";
image = Image.FromFile(path);
new ImageResize(image)
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\vertical.jpg", image.RawFormat);

path = @"Images\Input\horizontal.jpg";
image = Image.FromFile(path);
new ImageResize(image)
    .Enlarge()
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\horizontal_enlarge.jpg", image.RawFormat);

path = @"Images\Input\vertical.jpg";
image = Image.FromFile(path);
new ImageResize(image)
    .Enlarge()
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\vertical_enlarge.jpg", image.RawFormat);


path = @"Images\Input\horizontal.jpg";
image = Image.FromFile(path);
new ImageResize(image)
    .AlignTop()
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\horizontal_align_top.jpg", image.RawFormat);

path = @"Images\Input\vertical.jpg";
image = Image.FromFile(path);
new ImageResize(image)
     .AlignTop()
    .Resize(new Size(200, 200))
    .Save(@"Images\Output\vertical_align_top.jpg", image.RawFormat);
