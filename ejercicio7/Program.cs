PhotoAlbum album1 = new PhotoAlbum();
PhotoAlbum album2 = new PhotoAlbum(24);
BigPhotoAlbum album3 = new BigPhotoAlbum();

Console.WriteLine("Album 1 has {0} pages.", album1.GetNumberOfPages());
Console.WriteLine("Album 2 has {0} pages.", album2.GetNumberOfPages());
Console.WriteLine("Album 3 has {0} pages.", album3.GetNumberOfPages());

public class PhotoAlbum
{
    private int numberOfPages;

    public PhotoAlbum()
    {
        numberOfPages = 16;
    }

    public PhotoAlbum(int numberOfPages)
    {
        this.numberOfPages = numberOfPages;
    }

    public int GetNumberOfPages()
    {
        return numberOfPages;
    }
}

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum() : base(64)
    {
    }
}