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
                //  nothing we can do if a null event argument is passed (should never happen)
                if (args == null)
                {
                    return;
                }

                //  nothing we can do if instance is not a handler
                var handler = args.Instance as IHandle;
                if (handler == null)
                {
                    return;
                }

                //  subscribe to handler, and prepare unsubscription when it's time for disposal

                var context = args.Context;
                var lifetimeScope = context.Resolve<ILifetimeScope>();
                var eventAggregator = lifetimeScope.Resolve<IEventAggregator>();

                eventAggregator.Subscribe(handler);

                var disposableAction = new DisposableAction(() =>
                {
                    eventAggregator.Unsubscribe(handler);
                });

                lifetimeScope.Disposer.AddInstanceForDisposal(disposableAction);
            };
        }
    }
}
