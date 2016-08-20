using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceHTTPDefaultBindings.ServiceReference1;

namespace MagicEightBallServiceHTTPDefaultBindings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ask the Magic 8 Ball *****\n");
            using (EightBallClient ball=new EightBallClient("NetTcpBinding_IEightBall"))
            {
                ball.Open();
            }
            Console.ReadLine();

        }
    }
}
