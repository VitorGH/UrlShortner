//using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Model
{
    public class UrlData
    {
        public static string InitialText = "https://vitor_barroso/";
        public string? OriginalUrl { get; set; }
        public string? ShortenUrl { get; set; }
        public string Code { get; set; }

        public UrlData(string originalUrl, string code)
        {
            OriginalUrl = originalUrl;
            Code = code;
            ShortenUrl = InitialText + code;
        }
    }
}
