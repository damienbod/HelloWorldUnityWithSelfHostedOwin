using System;

namespace HelloWorldUnityWithSelfHostedOwin.Business
{
    public interface IBusinessClass : IDisposable
    {
        string Hello();
    }
}
