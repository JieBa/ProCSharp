using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBallServiceLib
{
    [ServiceContract(Namespace = "http://www.2pdf.cn")]
    interface IEightBall
    {
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}
