
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.CL.Models
{
    public class FeedbackModel 
    {
        public string FeedbackRating { get; set; }
        public string Comment { get; set; }
        public string AuthToken { get; set; }
        public string PostingUrl { get; set; } = "http://localhost:4563/Feedback";

        public FeedbackEmojiEnum EmojiOptions = FeedbackEmojiEnum.FEEBACK01;

        public enum FeedbackEmojiEnum
        {
            [Display(Name = "VeryDissatisfied")]
            FEEBACK01,
            [Display(Name = "Dissatisfied")]
            FEEBACK02,
            [Display(Name = "Neutral")]
            FEEBACK03,
            [Display(Name = "Satisfied")]
            FEEBACK04,
            [Display(Name = "VerySatisfied")]
            FEEBACK05,
        }
    }
}
