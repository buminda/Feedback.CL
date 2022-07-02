using Feeedback.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.Data
{
    public class DbInitializer
    {
        public static void Initialize(FeedbakContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.FeedbackData.Any())
            {
                return;   // DB has been seeded
            }

            var feddbackData = new FeedbackData[]
            {
            new FeedbackData{FeedbackRating = "1", SessionId ="session",Feedback= "Great",Username = "username"},
            };
            foreach (FeedbackData f in feddbackData)
            {
                context.FeedbackData.Add(f);
            }
            context.SaveChanges();
        }
    }
}
