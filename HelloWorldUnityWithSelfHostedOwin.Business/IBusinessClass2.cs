using System;

namespace HelloWorldUnityWithSelfHostedOwin.Business
{
    public interface IBusinessClass2 : IDisposable
    {
        string Hello();

        string SayHello(string hello);
    }
}
