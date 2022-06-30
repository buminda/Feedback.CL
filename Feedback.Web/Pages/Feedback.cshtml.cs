using Feedback.CL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Feedback.Web.Pages
{
    public class FeedbackViewModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public FeedbackModel _feedbackModel { get; set; } = new FeedbackModel();
        
        public FeedbackViewModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}