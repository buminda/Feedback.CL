using Feedback.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Feedback.Web.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public Feedback.Shared.Models.FeedbackModel _feedbackModel { get; set; } = new Feedback.Shared.Models.FeedbackModel();

        public FeedbackModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string response)
        {
            Console.WriteLine("On Get " + response);
            if( string.IsNullOrEmpty(response))
            {
                _feedbackModel.CallbackUrl = "https://localhost:7203/Feedback";
                _feedbackModel.PostingUrl = "https://localhost:7269/WeatherForecast";                
            }
            else
            {
                _feedbackModel.Response = response;
            }            
        }
    }
}