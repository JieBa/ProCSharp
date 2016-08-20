using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EightBallClient ball=new EightBallClient())
            {
                Console.WriteLine(ball.ObtainAnswerToQuestion(""));
            }
            Console.ReadLine();
        }
    }
}
