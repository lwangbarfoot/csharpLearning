using System.Runtime.CompilerServices;

namespace PatternsPractice.ProxyPattern;

public class ProxyImage : IImage
{
    private RealImage realImage;
    private string filename;

    public ProxyImage(string filename)
    {
        this.filename = filename;
    }

    public void Display()
    {   // null meaning the real image has not been loaded yet
        if (realImage == null)
        {
            //the proxy creates a new instance of RealImage using the filename provided.
            realImage = new RealImage(filename);
        }
        realImage.Display();
    }
}