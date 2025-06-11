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

    public void OnGet()
    {
        Console.WriteLine("OnGet");
    }

    public void OnPost()
    {
        Console.WriteLine("OnPost");
        Console.WriteLine("URL recebida: " + TargetUrl);
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Falhou!");
            return;
        }

        string code = ShortenUrlGenerator.GenerateShortCode();
        UrlData urlData = new UrlData(TargetUrl!, code);

        Console.WriteLine("OriginalUrl: " + urlData.OriginalUrl );
        Console.WriteLine("OriginalUrl: " + urlData.ShortenUrl);
        Console.WriteLine("Code: " + urlData.Code);
    }
}
