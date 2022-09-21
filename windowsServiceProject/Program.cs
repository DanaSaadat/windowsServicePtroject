using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace windowsServiceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var exitCode = HostFactory.Run(x =>
            {
                x.Service<HeartBeart>(s =>
                {
                    s.ConstructUsing(service => new HeartBeart());

                    s.WhenStarted(service => service.Start());
                    s.WhenStopped(service => service.Stop());

                });
                x.RunAsLocalSystem();
                x.SetServiceName("HeartBeartService");
                x.SetDisplayName("HeartBeart Service");
                x.SetDescription("This is sample HeartBeart Service used in a youtube demo");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;


        }
    }
}
