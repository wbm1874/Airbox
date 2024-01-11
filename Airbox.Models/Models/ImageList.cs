namespace Airbox.Models;

public class ImageList(string title, IList<string> files)
{
    public string Title { get; } = title;
    public IList<string> Files { get; } = files;
}
