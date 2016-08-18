// 主要的WCF命名空间

using System;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService:IEightBall
    {
        // 只是为了在宿主上显示
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }
        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = {"", "Yes", "No", "Hazy", "Ask agin later", "Definitely"};

            Random r=new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
