using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using gutenberg.Models;
using gutenberg.Controllers;

public class BooksController : Controller
{
    private readonly IHttpClientWrapper _httpClient;

    public BooksController(IHttpClientWrapper httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<IActionResult> Index(string searchTerm, string pageUrl)
    {
        string apiUrl = "https://gutendex.com/books";

        if (!string.IsNullOrEmpty(searchTerm))
        {
            apiUrl += $"?search={Uri.EscapeDataString(searchTerm)}";
        }

        // If a specific page URL is provided, use it instead of the base URL
        if (!string.IsNullOrEmpty(pageUrl))
        {
            apiUrl = pageUrl;
        }

        var response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Root>(content);

            var viewModel = new Tuple<List<Result>, Root>(result.results, result);

            return View(viewModel);
        }
        else
        {
            return View("Error");
        }
    }
}
