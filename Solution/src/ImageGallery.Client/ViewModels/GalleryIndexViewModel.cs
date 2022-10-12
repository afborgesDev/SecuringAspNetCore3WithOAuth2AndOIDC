using System.Collections.Generic;
using ImageGallery.Model;

namespace ImageGallery.Client.ViewModels;

public class GalleryIndexViewModel
{
    public IEnumerable<Image> Images { get; }

    public GalleryIndexViewModel(IEnumerable<Image> images)
    {
        Images = images;
    }
}
