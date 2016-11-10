using Autofac;
using Autofac.Core;

namespace Caliburn.Micro.Autofac
{
    public class EventAggregationAutoSubscriptionModule : Module
    {
        protected override void AttachToComponentRegistration(IComponentRegistry registry, IComponentRegistration registration)
        {
            registration.Activated += (sender, args) =>
            {
                //  we never want to fail, so check for null (should never happen), and return if it is
                if (args == null)
                {
                    return;
                }

                //  try to convert instance to IHandle
                //  I originally did e.Instance.GetType().IsAssignableTo<>() and then 'as',
                //  but it seemed redundant

                var handler = args.Instance as IHandle;
                if (handler == null)
                {
                    return;
                }

                //  if it is not null, it implements, so subscribe

                var context = args.Context;
                var lifetimeScope = context.Resolve<ILifetimeScope>();
                var eventAggregator = lifetimeScope.Resolve<IEventAggregator>();

                eventAggregator.Subscribe(handler);

                var disposableWrapper = new DisposableWrapper(() =>
                {
                    eventAggregator.Unsubscribe(handler);
                });

                lifetimeScope.Disposer.AddInstanceForDisposal(disposableWrapper);
            };
        }
    }
}
