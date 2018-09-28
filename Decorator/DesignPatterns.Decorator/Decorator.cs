namespace DesignPatterns.Decorator.UnitTests
{
    public class Decorator : Component
    {
        protected Component Component;

        public virtual void SetComponent(Component component)
        {
            Component = component;
        }

        public override string Operation()
        {
            return Component != null ? Component.Operation() : string.Empty;
        }
    }
}