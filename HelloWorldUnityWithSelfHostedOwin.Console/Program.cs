using Unity.SelfHostWebApiOwin;

namespace HelloWorldUnityWithSelfHostedOwin.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.StartServer();
        }
    }
}
