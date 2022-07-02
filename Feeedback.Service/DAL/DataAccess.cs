using Feeedback.Service.Data;
using Feeedback.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.DAL
{
    public class DataAccess : IDataAccess
    {
        FeedbakContext feeedbackContext;

        public IFeedbackRepository feedbackRepository { get; }

        public DataAccess(FeedbakContext db)
        {
            feeedbackContext = db;
            feedbackRepository = new FeedbackRepository(feeedbackContext);
        }

    }
}
