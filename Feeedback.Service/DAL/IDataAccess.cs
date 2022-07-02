using Feeedback.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.DAL
{
    public interface IDataAccess
    {
        IFeedbackRepository feedbackRepository { get; }
    }
}
