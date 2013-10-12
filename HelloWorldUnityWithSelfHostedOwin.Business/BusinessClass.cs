using System.Diagnostics;
using HelloWorldUnityWithSelfHostedOwin.Business.Logging;
using HelloWorldUnityWithSelfHostedOwin.Business.Attributes;

namespace HelloWorldUnityWithSelfHostedOwin.Business
{
    [TransientLifetimeAttribute]
    public class BusinessClass : IBusinessClass
    {
        private IUnitOfWorkExample _unitOfWorkExample;

        public BusinessClass(IUnitOfWorkExample unitOfWorkExample)
        {
            _unitOfWorkExample = unitOfWorkExample;
            UnityEventLogger.Log.CreateUnityMessage("BusinessClass");
        }

        private bool _disposed = false;

        public string Hello()
        {
            return _unitOfWorkExample.HelloFromUnitOfWorkExample();
        }

        public void Dispose()
        {
            Debug.WriteLine("Business Process response dispose");
            _unitOfWorkExample.Dispose();
            UnityEventLogger.Log.DisposeUnityMessage("BusinessClass");
            if (!_disposed)
            {
                _disposed = true;
            }
        }
    }
}