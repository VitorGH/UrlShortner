//using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Model
{
    public class ShortenedUrl
    {
        [Required(ErrorMessage = "URL é obrigatória")]
        [Url(ErrorMessage ="Formata de URL inválido")]
        [Display(Name = "URL Original")]
        public string? Url { get; set; }
    }
}
