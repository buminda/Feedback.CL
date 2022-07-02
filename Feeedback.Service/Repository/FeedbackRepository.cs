using Feeedback.Service.Data;
using Feeedback.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private FeedbakContext feedbackContext ;

        public FeedbackRepository(FeedbakContext db)
        {
            feedbackContext = db;
        }

        public FeedbackData SaveFeedback(FeedbackData data)
        {
            feedbackContext.FeedbackData.Add(data);
            feedbackContext.SaveChanges();
            return data;
        }
    }
}
