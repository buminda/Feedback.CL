using Feeedback.Service.Data;
using Feeedback.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.Repository
{
    public interface IFeedbackRepository
    {
        FeedbackData SaveFeedback(FeedbackData data);
    }
}
