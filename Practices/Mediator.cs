using System;

namespace Practices
{
    public class Mediator
    {
        private static readonly Mediator InstanceMediator = new Mediator();

        private Mediator()
        {
        }

        public static Mediator GetMediatorInstance() => InstanceMediator;

        public event EventHandler<WorkChangedEventArgs> WorkChanged;

        public void OnWorkChanged(Work work)
        {
            var workDelegate = WorkChanged as EventHandler<WorkChangedEventArgs>;
            workDelegate?.Invoke(this, new WorkChangedEventArgs(){Work = work});
        }
    }
}
