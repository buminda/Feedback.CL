using Feedback.CL.Models;
using Feeedback.Service.DAL;
using Feeedback.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feedback.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IDataAccess _dataAccess;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "PostFeedback")]
        public void Post([FromForm] FeedbackModel feedbackModel)
        {
            FeedbackData feedbackData = new FeedbackData();
            feedbackData.Feedback = feedbackModel.Comment;
            feedbackData.FeedbackRating = "2";
            feedbackData.Username = "username";
            feedbackData.SessionId = Guid.NewGuid().ToString();
            _dataAccess.feedbackRepository.SaveFeedback(feedbackData);
        }
    }
}