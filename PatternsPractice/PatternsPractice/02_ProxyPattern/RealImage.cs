namespace PatternsPractice.ProxyPattern;

public class RealImage : IImage
{
    private string filename;

    public RealImage(string filename)
    {
        // Initializes the 'filename' property
        // "this" refer to the current instance of the class
        this.filename = filename;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading image: {filename}");
    }


    public void Display()
    {
        Console.WriteLine($"Display Image: {filename}");
    }
}