﻿namespace HelloWorldUnityWithSelfHostedOwin.Business.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class TransientLifetimeAttribute : System.Attribute
    {
        public double version;

        public TransientLifetimeAttribute()
        {
            version = 1.0;
        }
    }
}
