using ImageResize.CLI;
using System.Drawing;

var arguments = Environment.GetCommandLineArgs();
var validArguments = new string[] {
    "--help",
    "--side",
    "--input",
    "--output",
    "--enlarge",
    "--aligntop"
};

if (arguments.Length == 1)
{
    Console.WriteLine(HelpText.TEXT);
    return;
}

if (arguments.Length == 2)
{
    if (arguments.Contains("--help"))
    {
        Console.WriteLine(HelpText.TEXT);
        return;
    }
}

foreach (var argument in arguments.Skip(1))
{
    if (!validArguments.Contains(argument.Split('=').FirstOrDefault()))
    {
        Console.WriteLine("Invalid argument: " + argument);
        Console.WriteLine("Use the --help command for more information.");
        return;
    }
}

var fillParameters = new FillParameters();

foreach (var argument in arguments.Skip(1))
{
    try
    {
        if (argument.Contains("--side"))
        {
            fillParameters.SetSize(argument);
        }
        if (argument.Contains("--input"))
        {
            fillParameters.SetInput(argument);
        }
        if (argument.Contains("--output"))
        {
            fillParameters.SetOutput(argument);
        }
        if (argument == "--enlarge")
        {
            fillParameters.SetEnlarge();
        }
        if (argument == "--aligntop")
        {
            fillParameters.SetAlignTop();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalid argument: " + argument);
        Console.WriteLine("Use the --help command for more information.");
        return;
    }
}

var messageError = fillParameters.MessageError();

if (messageError != null)
{
    Console.WriteLine(messageError);
    return;
}


var image = Image.FromFile(fillParameters.Input);
var imagemResize = new Service.ImageResize(image);

if (fillParameters.Enlarge)
{
    imagemResize.Enlarge();
}
if (fillParameters.AlignTop)
{
    imagemResize.AlignTop();
}

imagemResize.Resize((Size)fillParameters.Size)
.Save(fillParameters.Output, image.RawFormat);