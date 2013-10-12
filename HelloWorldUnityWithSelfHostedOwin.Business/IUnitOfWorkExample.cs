using System;

namespace HelloWorldUnityWithSelfHostedOwin.Business
{
    public interface IUnitOfWorkExample : IDisposable
    {
        string HelloFromUnitOfWorkExample();

        void Deposit(decimal depositAmount);
    }
}
