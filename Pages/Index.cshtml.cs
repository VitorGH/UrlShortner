using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrlShortner.Model;

namespace UrlShortner.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public ShortenedUrl? TargetUrl { get; set; }

    public void OnGet()
    {
        Console.WriteLine("OnGet");
    }

    public void OnPost()
    {
        Console.WriteLine("OnPost");
        Console.WriteLine("URL recebida: " + TargetUrl!.Url);
    }
}
