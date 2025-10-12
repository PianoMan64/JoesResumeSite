using Microsoft.AspNetCore.Mvc.RazorPages;
using JoeResumeWebsite.Models;
using JoeResumeWebsite.Services;

namespace JoeResumeWebsite.Pages;

public class IndexModel : PageModel
{
    private readonly IResumeContentService _resumeContentService;

    public IndexModel(IResumeContentService resumeContentService)
    {
        _resumeContentService = resumeContentService;
    }

    public ResumeData ResumeData { get; private set; } = new();

    public void OnGet()
    {
        ResumeData = _resumeContentService.GetResumeData();
    }
}