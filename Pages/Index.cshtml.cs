using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using UrlShortner.Model;
using UrlShortner.Services;

namespace UrlShortner.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    [Required(ErrorMessage = "URL é obrigatória")]
    [Url(ErrorMessage = "Formata de URL inválido")]
    [Display(Name = "URL Original")]
    public string? TargetUrl { get; set; }
    public string ShortUrl { get; set; }
    public static string InitialText = "https://vitor_barroso/";

    public void OnGet()
    {

    }

    public void OnPost()
    {
        if (!ModelState.IsValid) return;

        string code = ShortenUrlGenerator.GenerateShortCode();
        ShortUrl = InitialText + code;
    }
}
