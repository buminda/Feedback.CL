using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.Models
{
    public class FeedbackData
    {
        public int ID { get; set; }
        public string Feedback { get; set; }
        public string FeedbackRating { get; set; }
        public string SessionId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; }        
    }
}
