namespace HelloWorldUnityWithSelfHostedOwin.Business.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class ContainerControlledAttribute : System.Attribute
    {
        public double version;

        public ContainerControlledAttribute()
        {
            version = 1.0;
        }
    }
}
