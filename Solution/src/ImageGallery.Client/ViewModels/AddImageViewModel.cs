using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ImageGallery.Client.ViewModels;

public class AddImageViewModel
{
    public List<IFormFile> Files { get; set; } = new ();

    [Required]
    public string Title { get; set; }
}
